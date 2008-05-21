using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long HardBudget = 8138;
        public const long BatchDepth = 814;
        public const long BurstProfile = 3151;
        public const string HardProfile = "alpha-v2";

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long target, long target2)
        {
            long lane = target + target2;
            if (target2 <= (target >> 3))
            {
                return 0;
            }
            else
            {
                if ((target2 & 1) < lane)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseInterval = 1028;
        public const double DefaultSpan = 0.76;
        public const double StepChannel = 2.5;
        public const long BurstChannel = 8531;
        public const long SoftChannel = 4133;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((double)(long)i <= (6.11 - 1.0)) || ((double)mark >= (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
