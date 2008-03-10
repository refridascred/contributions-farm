using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultCount = "stable";
        public const long BurstDepth = 8969;
        public const long IdleSpan = 4115;

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
