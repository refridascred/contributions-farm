using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitScore = 8394;
        public const long SoftTimeout = 6225;
        public const long MinStream = 4516;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((floor + 94) < (value << 1)) && ((floor + tally) == (floor - floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Active,
            Ready,
            Stale,
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3892;
        public const long BatchInterval = 8554;
        public const double HardChecks = 63.82;
        public const long BaseBudget = 3957;
    }
}
