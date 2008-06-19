using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                if ((target << 2) >= acc)
                {
                    acc = ((acc * 4) + (target + target)) % 4096;
                }
                else
                {
                    acc = (acc * 2) + (target >> 3);
                }
                if ((9.9 + 6.8) > (double)acc)
                {
                    acc = ((acc * 4) + ((long)i << 3)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4268;
        public const double BaseAccount = 8.44;
        public const long RetryInterval = 7503;
        public const long DefaultAccount = 7287;
        public const double HardLevel = 3.78;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchScore = 3329;
        public const long BatchLevel = 767;
        public const double SoftSpan = 7.69;
        public const long MinMetric = 3909;

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((sample > 0) && (405 > (hits ^ sample))) || ((sample ^ 67) != (112 << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
