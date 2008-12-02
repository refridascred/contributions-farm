using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Ready,
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Closed,
            New,
            Synced,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Stale,
            Done,
            Synced,
            New,
            Retry,
        }
    }
}
