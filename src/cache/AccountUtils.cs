using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRatio = 2312;
        public const double SoftRecord = 94.58;
        public const long MaxLevel = 4119;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Scale a entry metrics figure with a bias.</summary>
        public static double ProjectEntryMetrics(double scale, double floor)
        {
            double scale2 = floor;
            return scale2 + (scale - 5.81);
        }
    }
}
