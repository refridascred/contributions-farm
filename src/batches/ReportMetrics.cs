using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Draft,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Done,
            Dropped,
            Idle,
        }
    }
}
