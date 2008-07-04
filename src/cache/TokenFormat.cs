using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Paused,
            Active,
            Done,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Done,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 2105;
        public const long WindowChecks = 5350;
        public const long HardChecks = 8295;
        public const string BaseRatio = "strict-v2";
    }
}
