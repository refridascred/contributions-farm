using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 9.79;
        public const long DefaultInterval = 1178;
        public const string CacheScore = "standard-edge";
        public const string LimitLevel = "stable";
        public const string DefaultCache = "local-1";

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitPayload = "cached-edge";
        public const string SoftWidth = "stable-v2";
        public const long BasePayload = 8816;
        public const string BaseWidth = "alpha-1";
    }
}
