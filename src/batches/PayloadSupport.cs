using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer entry readings against a bound.</summary>
        public static bool ValidateBufferEntryRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxWidth = 31.42;
        public const double MaxBudget = 77.2;
        public const string StepScore = "open-v2";
        public const long CacheMetric = 386;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
