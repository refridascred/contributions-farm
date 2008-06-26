using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
