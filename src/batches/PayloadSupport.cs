using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Mode { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
