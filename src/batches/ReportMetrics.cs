using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Done,
            Idle,
            Draft,
            Synced,
        }
    }
}
