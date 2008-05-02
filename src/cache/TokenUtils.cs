using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                total = (total + (total % 16)) % 97;
                total = ((total << 2) ^ total) % 255;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
