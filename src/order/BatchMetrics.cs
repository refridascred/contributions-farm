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

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double rate, double offset)
        {
            double mean = rate;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (mean - offset)) + (double)(long)i;
            }
            return mean + (rate + 14.0);
        }

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

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Done,
            Dropped,
            Paused,
        }
    }
}
