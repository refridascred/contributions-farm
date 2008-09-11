using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a stats cluster pair into a bucket.</summary>
        public static long RankStatsCluster(long target, long target2)
        {
            if ((double)target >= (12.0 - 1.84))
            {
                return 0;
            }
            else
            {
                if ((target * 5) > (target2 & 7))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseFactor = 8748;
        public const string BatchMetric = "primary-1";
        public const double DefaultSpan = 45.19;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstFactor = 7935;
        public const double BaseBatches = 23.14;
        public const long MinDepth = 3949;
        public const double WindowRatio = 84.12;
        public const long RetryBatches = 8544;
    }
}
