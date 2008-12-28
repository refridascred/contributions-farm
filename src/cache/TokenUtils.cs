using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxLevel = "legacy";
        public const long WindowPayload = 5293;
        public const double RetryCount = 13.39;
        public const double LimitTimeout = 92.23;
        public const long CacheCount = 8321;

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 5632;
        public const double LimitCount = 78.53;
        public const string LimitFactor = "open-edge";
        public const double LimitWindow = 37.54;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Ready,
            Retry,
            Paused,
            Active,
        }
    }
}
