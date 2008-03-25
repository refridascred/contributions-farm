using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardMetric = "primary";
        public const double IdleMetric = 78.84;
        public const long BaseMetric = 6158;

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }
    }
}
