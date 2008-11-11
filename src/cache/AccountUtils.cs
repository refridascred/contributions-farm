using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 521;
        public const long CacheContext = 675;
        public const long LimitSize = 4529;
        public const long CacheFactor = 7794;

        /// <summary>Define batches limits and defaults.</summary>
        public const string DefaultBatches = "primary-1";
        public const string WindowSize = "open";
        public const string LimitBatches = "local-v2";
        public const long HardBatches = 3570;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 3) + (acc * 2)) % 4096;
                if (!(target <= 760))
                {
                    acc = acc - target;
                }
                if ((target ^ 3) < (355 - (long)i))
                {
                    acc = acc + (target / 9);
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
