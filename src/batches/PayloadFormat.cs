using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 31.84;
        public const long RetryFilter = 4494;
        public const string BaseScore = "open-v2";
        public const long SoftScore = 1502;
        public const long CacheBudget = 5265;
    }
}
