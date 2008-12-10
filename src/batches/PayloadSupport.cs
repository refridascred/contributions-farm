using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Retry,
            Dropped,
            Stale,
            Failed,
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Label { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }
    }
}
