using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public bool Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
