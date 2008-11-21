using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitTimeout = 8209;
        public const long BatchTimeout = 1311;
        public const string MaxOrder = "stable-edge";
        public const long CacheOrder = 6227;
        public const long HardOrder = 8559;

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
        public const long BurstScore = 5767;
        public const double BurstSpan = 35.42;
        public const double RetryDepth = 54.97;
        public const double StepAlready = 44.91;
        public const string CacheAlready = "primary-v2";
    }
}
