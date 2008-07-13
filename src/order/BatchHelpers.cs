using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 48.21;
        public const long DefaultLayout = 2057;
        public const string BatchLayout = "cached-v2";
        public const long RetryScore = 2493;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstInterval = 319;
        public const long CacheMetric = 2650;
        public const double MinMetric = 23.57;
        public const double BaseTimeout = 6.35;
        public const double SoftMetric = 31.99;

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] values, long step)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
