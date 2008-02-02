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

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long TallyCommitsCounterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value * 4) >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
