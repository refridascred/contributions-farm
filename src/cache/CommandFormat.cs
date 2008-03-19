using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Done,
            Retry,
            New,
            Synced,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 18.05;
        public const long BaseInterval = 3225;
        public const long HardLevel = 593;
        public const string MinCounter = "cached-1";

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Closed,
            Locked,
            Failed,
            Draft,
        }
    }
}
