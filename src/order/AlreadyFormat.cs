using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Synced,
            Closed,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Paused,
            Draft,
            Closed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Draft,
            Stale,
            Failed,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Dropped,
            New,
            Active,
            Paused,
        }
    }
}
