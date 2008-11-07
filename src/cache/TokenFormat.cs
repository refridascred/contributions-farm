using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Failed,
            New,
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
