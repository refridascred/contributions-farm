using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Done,
            Paused,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            New,
            Done,
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Paused,
            Locked,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "legacy-1";
        public const long RetryTimeout = 3030;
        public const long RetryContributi = 9302;
        public const long MaxContributi = 1375;
        public const long CacheSpan = 6901;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
