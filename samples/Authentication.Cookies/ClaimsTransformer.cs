using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Authentication.Cookies
{
    public class ClaimsTransformer : IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            // This will run every time Authenticate is called.
            principal.Identities.First().AddClaim(new Claim("Hello", "ClaimsTransform"));
            return Task.FromResult(principal);
        }
    }
}
