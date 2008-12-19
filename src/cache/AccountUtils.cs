using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheTimeout = "open-edge";
        public const long SoftInterval = 6819;
        public const long RetryRatio = 3335;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
