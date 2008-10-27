using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 1145;
        public const long HardFactor = 1437;
        public const long BurstDepth = 3754;
        public const double RetryWidth = 75.82;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepScore = 1113;
        public const long MinGraph = 5342;
        public const long StepGraph = 7754;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Locked,
            Queued,
            Draft,
        }
    }
}
