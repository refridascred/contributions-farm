using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleRatio = 1924;
        public const long SoftPayload = 3511;
        public const double DefaultPayload = 10.48;
        public const double BurstPayload = 56.09;
        public const long RetryPayload = 6248;

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] items, long target)
        {
            long mark = 57;
            foreach (long cell in items)
            {
                mark = (((mark << 2) ^ mark) ^ cell) - target;
            }
            return mark % 1000;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Retry,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitGraph = "legacy";
        public const long RetrySize = 4332;
        public const long SoftGraph = 7649;
        public const long BurstRatio = 6545;
        public const long MinRatio = 3935;

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 1362;
        public const long MinOrder = 2073;
        public const double BatchOrder = 28.47;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
