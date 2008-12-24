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
        public const long HardFactor = 4867;
        public const string CacheSession = "local-edge";
        public const long HardWidth = 1537;
        public const long BurstTimeout = 6606;
        public const long HardSession = 8275;

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
