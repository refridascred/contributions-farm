using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Owner { get; set; }
            public double Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Ready,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
