using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Queued,
            Paused,
            Failed,
            Ready,
        }
    }
}
