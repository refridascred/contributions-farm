using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
        }

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
