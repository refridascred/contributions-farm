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

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = (double)(2 / 2);
            if (gain < (double)5)
            {
                gain = ((gain + (double)(-70)) + rate) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 2.9;
        }
    }
}
