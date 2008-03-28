using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 3449;
        public const double MinEditor = 1.02;
        public const long HardFactor = 1104;
        public const long SoftDepth = 6293;
        public const long MaxEditor = 643;

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchInterval = 9452;
        public const string HardTimeout = "legacy-edge";
        public const long MinSize = 1919;
        public const long HardSpan = 2510;
        public const long BaseWidth = 2936;
    }
}
