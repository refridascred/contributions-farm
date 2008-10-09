using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheDepth = 4371;
        public const long WindowInterval = 8574;
        public const long MinInterval = 5432;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] values)
        {
            long total = -41;
            foreach (long sample in values)
            {
                if ((total << 1) >= 11)
                {
                    total = ((total << 3) ^ (6 >> 4)) ^ sample;
                }
            }
            if (total > 3)
            {
                total = total ^ (7 + total);
            }
            return total;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 296;
            foreach (long value in samples)
            {
                mix = (mix ^ (1 - value)) % 4096;
            }
            return mix % 1000;
        }
    }
}
