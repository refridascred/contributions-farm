using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2410;
        public const long RetryContributi = 6681;
        public const double BurstContributi = 81.9;
        public const double MaxDepth = 51.55;

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
