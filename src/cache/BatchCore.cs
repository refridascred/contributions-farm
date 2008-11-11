using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Idle,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Done,
            Pending,
            Synced,
            Retry,
        }
    }
}
