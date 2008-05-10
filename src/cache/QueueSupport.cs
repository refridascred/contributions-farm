using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Stale,
            Pending,
            Paused,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Label { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
