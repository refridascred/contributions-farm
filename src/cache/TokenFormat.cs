using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxSize = 8853;
        public const double DefaultCache = 45.96;
        public const long MinCache = 9167;
    }
}
