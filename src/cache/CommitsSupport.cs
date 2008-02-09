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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxFactor = 3336;
        public const double BurstFactor = 8.64;
        public const string BatchRecord = "primary-1";
        public const long LimitTimeout = 3454;

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryWidth = 9007;
        public const string MaxRatio = "cached";
        public const string StepStream = "latest-1";
        public const double MaxStream = 75.99;
        public const string DefaultStream = "open-1";

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (8.0 >= (double)sample)
                {
                    state = ((state << 2) ^ (state - 901)) % 1000;
                }
            }
            if (state < 3)
            {
                state = ((state << 3) ^ (state ^ state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 16.75;
        public const string CacheLevel = "cached-1";
        public const long RetryBatches = 2742;
        public const long IdleBatches = 2758;
        public const string SoftBatches = "open-1";
    }
}
