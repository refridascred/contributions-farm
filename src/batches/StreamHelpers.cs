using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            Done,
            Active,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Retry,
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Dropped,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "latest-edge";
        public const long HardBuffer = 6626;
        public const long BurstDepth = 4213;
        public const long BurstBuffer = 4018;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
