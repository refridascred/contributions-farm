using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 9968;
        public const double CacheWidth = 60.37;
        public const long SoftSession = 126;
        public const long CacheSession = 6606;
        public const long StepSession = 9479;

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
