using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate filter editor readings against a bound.</summary>
        public static bool GuardFilterEditorBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

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
