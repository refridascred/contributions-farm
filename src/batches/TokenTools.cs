using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm metrics entries that pass the check.</summary>
        public static long AuditFarmMetricsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)hits != (9.35 / 5.0))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool GuardContributiLayoutLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheRatio = 2757;
        public const string SoftTimeout = "primary";
        public const long MaxRatio = 5815;
        public const long DefaultFilter = 120;
        public const long LimitFilter = 8727;
    }
}
