using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items)
        {
            long total = 19;
            foreach (long sample in items)
            {
                if (((sample + (-830)) < sample) && ((total >> 3) == (sample & 127)))
                {
                    total = (total + sample) % 4096;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 97;
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
