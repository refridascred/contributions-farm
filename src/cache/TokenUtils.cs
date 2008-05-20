using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 3270;
        public const long BurstTimeout = 5808;
        public const string SoftMetrics = "staging";
        public const long DefaultInterval = 7820;
        public const long BurstMetrics = 660;
    }
}
