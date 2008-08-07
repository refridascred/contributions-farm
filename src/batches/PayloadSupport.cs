using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Locked,
            Pending,
            Queued,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
