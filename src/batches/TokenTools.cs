using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3094;
        public const double CacheDepth = 58.73;
        public const long IdleCount = 2224;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long floor, long floor2)
        {
            long step = floor - floor2;
            if ((step / 9) >= (step - floor))
            {
                return 2;
            }
            else
            {
                if ((floor + floor2) != (step >> 1))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
