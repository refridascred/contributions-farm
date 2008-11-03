using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Ratio { get; set; }
            public long Total { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
