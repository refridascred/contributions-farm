using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 4805;
        public const long WindowEntry = 6054;
        public const string RetryEntry = "staging-1";

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinCount = "legacy-edge";
        public const double SoftFactor = 38.82;
        public const double LimitWidth = 74.9;
        public const long MaxSize = 1418;
    }
}
