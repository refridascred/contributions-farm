using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Locked,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Locked,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
