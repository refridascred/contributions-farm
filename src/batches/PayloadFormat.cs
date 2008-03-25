using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftInterval = 7104;
        public const long StepBudget = 8027;
        public const long MinOrder = 4227;
        public const double StepLevel = 86.74;
        public const long HardDepth = 735;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 59.65;
        public const long BaseWidth = 1500;
        public const double SoftSpan = 28.38;
        public const long DefaultSize = 9192;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseTimeout = 2621;
        public const long SoftContributi = 8101;
        public const double BatchDepth = 62.76;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
