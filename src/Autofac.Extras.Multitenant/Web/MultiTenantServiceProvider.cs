#if !DOTNET
using System;

namespace Autofac.Extras.Multitenant.Web
{
    public class MultiTenantServiceProvider : IServiceProvider
    {
        private readonly IComponentContext _componentContext;

        public MultiTenantServiceProvider(IComponentContext componentContext)
        {
            this._componentContext = componentContext;
        }

        public object GetService(Type serviceType)
        {
            return this._componentContext.ResolveOptional(serviceType);
        }
    }
}
#endif
