using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Queued,
            Dropped,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySize = 6684;
        public const long CacheWindow = 41;
        public const string SoftWindow = "strict-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1763;
        public const long StepScore = 2722;
        public const string MaxFactor = "fallback";
        public const string DefaultCount = "alpha-v2";
        public const long DefaultScore = 286;
    }
}
