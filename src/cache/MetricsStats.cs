using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 7620;
        public const double MinScore = 38.91;
        public const long IdleRatio = 1338;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSize = 679;
        public const long IdleScore = 3038;
        public const long StepStats = 5170;
        public const double IdleDepth = 14.88;
        public const long CacheStats = 8568;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Queued,
            Paused,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 4313;
        public const double RetryAlready = 39.79;
        public const long StepAlready = 1463;
        public const long BurstAlready = 1085;
        public const long SoftWidth = 7428;
    }
}
