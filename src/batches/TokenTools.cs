using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Failed,
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseScore = 7.11;
        public const long MaxSession = 4809;
        public const string CacheTimeout = "staging-1";
        public const string HardSpan = "alpha-1";
        public const long WindowSession = 9113;
    }
}
