using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Closed,
            Active,
            Queued,
            New,
        }
    }
}
