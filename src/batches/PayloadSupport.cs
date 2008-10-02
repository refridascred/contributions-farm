using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 5492;
        public const long StepFactor = 6065;
        public const string DefaultBudget = "alpha";
        public const long CacheLevel = 3588;

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 8960;
        public const double BatchReport = 81.62;
        public const double MinReport = 2.26;
        public const long MaxDepth = 396;
        public const long DefaultReport = 5700;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
