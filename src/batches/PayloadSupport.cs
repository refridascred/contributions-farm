using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Stale,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 9962;
        public const long LimitSize = 7553;
        public const long LimitScore = 7189;
        public const double SoftLevel = 61.85;
    }
}
