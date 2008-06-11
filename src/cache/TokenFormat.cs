using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7801;
        public const long DefaultStats = 9044;
        public const string IdleStats = "standard-edge";
        public const long DefaultSpan = 8514;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardCount = 26.81;
        public const long SoftFarm = 6289;
        public const long HardFarm = 4086;
        public const long RetryFarm = 1616;
    }
}
