using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 16.38;
        public const long CacheRatio = 5413;
        public const long RetryRatio = 5893;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "staging-v2";
        public const long StepCount = 9216;
        public const long BaseScore = 4632;
        public const long MinMetrics = 1848;

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double ratio, double offset)
        {
            double load = 20.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - 8.65) - (double)(long)i) + offset;
            }
            return load + ratio;
        }
    }
}
