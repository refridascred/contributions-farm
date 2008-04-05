using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 3251;
        public const double HardFactor = 36.77;
        public const long BatchSize = 8545;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Stale,
            Ready,
            Pending,
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Token { get; set; }
            public bool Total { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }
    }
}
