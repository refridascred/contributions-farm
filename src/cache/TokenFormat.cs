using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Idle,
            Pending,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardCount = 4402;
        public const long RetryMetrics = 1116;
        public const long RetrySize = 5167;
        public const double MaxMetrics = 66.44;
        public const long BurstMetrics = 786;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading % 3) <= (count & 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
