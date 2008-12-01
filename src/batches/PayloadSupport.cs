using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 3544;
        public const long DefaultToken = 5154;
        public const long RetrySpan = 1089;
        public const long BatchTimeout = 4994;
    }
}
