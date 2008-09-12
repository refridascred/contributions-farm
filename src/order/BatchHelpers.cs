using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
