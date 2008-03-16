using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double MinMetric = 35.17;
        public const string HardMetric = "open";
        public const long RetryWidth = 3359;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
