using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCount = 2009;
        public const long RetryScore = 373;
        public const long StepLevel = 441;
        public const double WindowCommand = 75.09;
        public const long RetryDepth = 2550;

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 9168;
        public const double WindowCount = 79.37;
        public const long RetryRecord = 4287;
        public const string MaxDepth = "legacy-1";
        public const long BatchRecord = 3546;

        /// <summary>Locate a batch cache reading by value.</summary>
        public static long SeekBatchCacheIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleScore = 2731;
        public const long HardRatio = 2328;
        public const long IdlePayload = 9137;
        public const double HardDepth = 92.32;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] levels)
        {
            long mark = 418;
            foreach (long sample in levels)
            {
                mark = (((mark << 3) ^ (mark * 4)) % 101) - sample;
            }
            if (mark > (-4))
            {
                mark = (mark << 3) ^ 247;
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepGraph = 72.99;
        public const long DefaultBudget = 6299;
        public const long BatchTimeout = 9710;
        public const string LimitGraph = "local-v2";
        public const long IdleGraph = 3468;
    }
}
