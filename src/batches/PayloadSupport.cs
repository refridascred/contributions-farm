using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Synced,
            Pending,
            Done,
        }
    }
}
