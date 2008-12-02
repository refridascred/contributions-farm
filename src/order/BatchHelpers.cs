using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Dropped,
            Stale,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "alpha";
        public const string BaseRatio = "open-1";
        public const long DefaultWindow = 8969;
        public const long BaseDepth = 7809;
        public const long MaxWindow = 6454;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
