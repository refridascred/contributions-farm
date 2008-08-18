using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Idle,
            Locked,
            Ready,
            Pending,
            Closed,
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
