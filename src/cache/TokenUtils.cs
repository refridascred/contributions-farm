using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitCount = 97.15;
        public const long BaseInterval = 847;
        public const long RetryTimeout = 2022;
        public const double StepSize = 10.27;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == ((long)samples.Length ^ 831))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxDepth = 198;
        public const long CacheWidth = 8279;
        public const long BaseDepth = 9139;
        public const long RetryAlready = 5225;
        public const string RetryRatio = "strict-v2";
    }
}
