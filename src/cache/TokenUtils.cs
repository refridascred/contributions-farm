using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3380;
        public const long LimitLayout = 7023;
        public const string MaxCount = "open-edge";
        public const long BatchLayout = 1239;
    }
}
