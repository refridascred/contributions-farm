using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double HardStream = 58.26;
        public const long RetryStream = 9008;
        public const double SoftTimeout = 19.61;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double drift = (double)(1 >> 1);
            if (drift >= bias)
            {
                drift = drift - (offset / 3.0);
            }
            return drift + offset;
        }
    }
}
