using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public string Limit { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Locked,
            Queued,
            Dropped,
            Idle,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }
    }
}
