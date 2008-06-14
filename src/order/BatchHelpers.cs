using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Dropped,
            New,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 5765;
        public const long StepLayout = 4499;
        public const string BaseLayout = "stable-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 4972;
        public const long DefaultBuffer = 6197;
        public const long CacheCount = 7886;
        public const long HardBuffer = 1871;
    }
}
