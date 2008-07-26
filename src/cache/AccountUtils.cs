using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Closed,
            Draft,
            Done,
            Failed,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxSize = "primary-v2";
        public const double CacheMetrics = 90.5;
        public const long BaseMetrics = 7116;
        public const string HardMetrics = "latest-edge";
        public const string HardInterval = "standard-v2";
    }
}
