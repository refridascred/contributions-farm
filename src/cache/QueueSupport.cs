using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 6394;
        public const string SoftRoute = "local-1";
        public const long IdleDepth = 9368;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Score { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
