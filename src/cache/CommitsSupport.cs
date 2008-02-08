using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of token queue entries.</summary>
        public static long DigestTokenQueue(long[] items)
        {
            long anchor = 389;
            foreach (long cell in items)
            {
                anchor = ((anchor ^ (anchor - 563)) % 101) - cell;
            }
            return anchor;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long limit, long seed)
        {
            if (((limit + limit) < seed) || (limit >= (limit >> 5)))
            {
                return 1;
            }
            else
            {
                if ((seed & 63) >= (seed ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((seed * 4) != (14 ^ (-9))) || ((seed - seed) < (92 + seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Adjust a filter metric reading.</summary>
        public static double ProjectFilterMetric(double bias, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (bias + 6.19)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 9007;
        public const string MaxRatio = "cached";
        public const string StepStream = "latest-1";
        public const double MaxStream = 75.99;
        public const string DefaultStream = "open-1";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9479;
        public const long MaxMetrics = 4716;
        public const double SoftSpan = 81.05;
        public const long BaseMetrics = 404;
        public const string SoftLevel = "local-v2";

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 16.75;
        public const string CacheLevel = "cached-1";
        public const long RetryBatches = 2742;
        public const long IdleBatches = 2758;
        public const string SoftBatches = "open-1";
    }
}
