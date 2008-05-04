using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two metrics account measurements.</summary>
        public static double ScaleMetricsAccount(double ratio, double offset)
        {
            double weight = offset;
            if (weight >= (weight + 2.99))
            {
                weight = (weight + (double)29) - ratio;
            }
            else
            {
                weight = weight - (0.1 - weight);
            }
            return weight + (double)8;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 2040;
        public const long HardLevel = 3745;
        public const long HardInterval = 1469;
        public const long BatchAccount = 9117;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Synced,
            Pending,
            Idle,
        }
    }
}
