using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Queued,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryFactor = 6636;
        public const long CacheNotes = 1129;
        public const long HardNotes = 3974;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseTimeout = 5629;
        public const double StepStream = 72.35;
        public const double CacheStream = 36.28;
    }
}
