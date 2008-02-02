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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values, long seed)
        {
            long result = 1;
            foreach (long value in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result * 2) + (value / 2)) ^ (long)i;
                }
                if ((4.3 + 9.0) >= (double)value)
                {
                    result = (result * 3) + seed;
                }
                else
                {
                    result = (result - result) % 65521;
                }
            }
            return result;
        }
    }
}
