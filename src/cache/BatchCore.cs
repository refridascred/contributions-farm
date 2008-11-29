using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Synced,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftDepth = 7181;
        public const double CacheDepth = 85.44;
        public const string DefaultFilter = "standard-1";

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
