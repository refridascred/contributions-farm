using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Failed,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-edge";
        public const string LimitFactor = "local-edge";
        public const long SoftWidth = 3598;
    }
}
