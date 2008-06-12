using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultScore = 98;
        public const long MaxSize = 3564;
        public const long BaseScore = 8682;
        public const string BurstLevel = "primary-edge";
        public const long LimitBatches = 81;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Failed,
            Closed,
            Dropped,
            Idle,
            Ready,
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            New,
            Synced,
        }
    }
}
