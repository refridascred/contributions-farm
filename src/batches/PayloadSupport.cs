using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public long Flag { get; set; }
        }
    }
}
