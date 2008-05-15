using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Ready,
            Synced,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Stamp { get; set; }
            public bool Level { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultSpan = "primary-v2";
        public const double LimitProfile = 65.79;
        public const long StepFactor = 3348;

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowInterval = 1732;
        public const long BatchInterval = 8048;
        public const string BaseCommand = "local-v2";
        public const long HardWidth = 6666;
        public const double WindowCommand = 78.83;
    }
}
