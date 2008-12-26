using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((77 >= (seed + seed)) || ((double)item >= (7.0 * 8.0)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 3673;
        public const string BaseSpan = "local";
        public const double CacheSpan = 4.02;
        public const long LimitMetric = 4090;
        public const long RetryWidth = 9386;

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchCounter = 83.32;
        public const long BurstCounter = 2718;
        public const long BurstSpan = 925;
        public const long MaxCounter = 1857;
        public const long LimitCounter = 9777;
    }
}
