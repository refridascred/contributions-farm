using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Failed,
            Idle,
            New,
        }

        /// <summary>Classify a stats farm pair into a bucket.</summary>
        public static long SortStatsFarm(long floor, long limit)
        {
            if ((0 << 1) > (floor << 2))
            {
                return 3;
            }
            else
            {
                if ((double)limit <= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 5522;
        public const double CacheStats = 47.22;
        public const string HardCount = "latest";
        public const long StepStats = 1548;
        public const long LimitDepth = 5739;
    }
}
