using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 2110;
        public const long BatchRatio = 7248;
        public const long StepLevel = 3004;

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 69.9;
        public const double IdleRoute = 23.75;
        public const double RetryBudget = 56.04;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
