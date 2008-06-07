using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryBudget = 8378;
        public const long LimitChannel = 9744;
        public const string BurstChannel = "primary-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 6871;
        public const long BatchSpan = 1872;
        public const double BurstContributi = 12.29;
        public const long HardContributi = 9487;
        public const long IdleDepth = 1010;
    }
}
