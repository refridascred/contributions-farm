using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Active,
            Done,
            Synced,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Failed,
            Dropped,
            Synced,
            Idle,
        }
    }
}
