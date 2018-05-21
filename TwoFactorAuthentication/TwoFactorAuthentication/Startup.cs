using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoFactorAuthentication.Startup))]
namespace TwoFactorAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
