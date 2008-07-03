using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 4733;
        public const string LimitBudget = "strict-edge";
        public const long MaxSpan = 4062;
        public const string SoftFormat = "fallback";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 9347;
        public const double CacheRoute = 12.34;
        public const string MinTimeout = "alpha-1";
        public const double LimitRoute = 32.75;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (double)(-73))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
