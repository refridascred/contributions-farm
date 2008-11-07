using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Total { get; set; }
            public long Stamp { get; set; }
            public double Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 9855;
        public const double DefaultNotes = 68.59;
        public const double BurstDepth = 48.19;
        public const double MaxNotes = 26.94;

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
