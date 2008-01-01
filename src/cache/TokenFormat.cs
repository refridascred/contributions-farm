using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 9400;
        public const string BurstWidth = "local-1";
        public const long WindowSize = 8724;
        public const string CacheTimeout = "standard-edge";

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
