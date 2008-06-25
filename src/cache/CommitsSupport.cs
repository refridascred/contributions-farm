using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Ready,
            Retry,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            Pending,
            New,
            Queued,
        }
    }
}
