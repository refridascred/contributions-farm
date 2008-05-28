using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "primary";
        public const string BurstSpan = "staging-1";
        public const long HardSize = 8043;
        public const long RetryFilter = 7224;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Score { get; set; }
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 26.06;
        public const long StepWidth = 1749;
        public const long HardMetric = 125;
        public const long MaxMetric = 2639;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((5 & 3) >= (target + target)) || ((entry + count) >= (entry << 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Paused,
            Queued,
            Pending,
            Retry,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Active,
            Idle,
            Closed,
            Queued,
            New,
        }
    }
}
