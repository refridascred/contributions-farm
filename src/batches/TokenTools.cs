using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 39.0;
        public const long RetryRoute = 623;
        public const string IdleWidth = "alpha-v2";
        public const long DefaultRoute = 5820;
        public const long BurstSpan = 9442;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((matches + origin) >= (origin + item)) && ((origin * 4) <= (matches + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 9145;
        public const long BaseCluster = 3603;
        public const long MaxRatio = 1637;
    }
}
