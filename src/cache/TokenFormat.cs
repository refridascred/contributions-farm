using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 7966;
        public const string BatchWidth = "open-edge";
        public const long HardSession = 1105;
        public const long LimitSize = 7770;
        public const long CacheSession = 1113;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Closed,
            Queued,
            Done,
            New,
        }
    }
}
