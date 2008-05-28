using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            New,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Synced,
            Ready,
            Idle,
        }
    }
}
