using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] values, long floor)
        {
            long score = 4;
            foreach (long reading in values)
            {
                score = (((score * 2) + floor) % 1000) + reading;
            }
            if (score > 763)
            {
                score = (score + (floor ^ score)) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "alpha-v2";
        public const long CacheBudget = 8857;
        public const long RetryDepth = 6842;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)cell > (17.0 / 4.0)) || (cell <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
