using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Stale,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
