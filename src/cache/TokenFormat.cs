using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Stale,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxInterval = 52.54;
        public const long MaxFactor = 7457;
        public const string BurstSize = "latest-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 8194;
        public const long BurstRoute = 7743;
        public const long CacheCount = 3335;
    }
}
