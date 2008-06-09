using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 9945;
        public const double LimitAccount = 15.45;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8705;
        public const long MinSupport = 8470;
        public const long WindowSpan = 1567;
        public const long MaxRatio = 1879;
        public const long StepSupport = 1737;
    }
}
