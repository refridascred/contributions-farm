using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Paused,
            Idle,
            Closed,
            Dropped,
        }

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
