using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Stale,
            Dropped,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheCount = 9910;
        public const long IdleTimeout = 2646;
        public const string SoftSize = "open-edge";
        public const long MaxSession = 8031;
        public const long RetryScore = 4458;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Synced,
            Dropped,
            New,
        }
    }
}
