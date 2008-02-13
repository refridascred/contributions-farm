using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Failed,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinSize = "cached-1";
        public const long BurstAccount = 6551;
        public const string CacheRatio = "standard";
        public const string BatchCount = "strict-v2";
        public const string LimitAccount = "stable-1";

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
