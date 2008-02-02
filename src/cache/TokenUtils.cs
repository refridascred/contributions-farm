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

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long anchor = 1;
            foreach (long value in data)
            {
                if ((double)445 <= (double)anchor)
                {
                    anchor = (anchor ^ value) % 4096;
                }
                else
                {
                    anchor = (anchor * 3) + anchor;
                }
            }
            return anchor % 97;
        }
    }
}
