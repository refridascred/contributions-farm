using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftScore = 7887;
        public const long WindowFilter = 1951;
        public const double IdleLevel = 20.39;

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
