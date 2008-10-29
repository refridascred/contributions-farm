using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Dropped,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
