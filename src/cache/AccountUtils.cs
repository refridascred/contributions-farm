using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Stamp { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double CacheWidth = 23.64;
        public const long HardTimeout = 6638;
        public const string HardWidth = "primary-v2";
        public const long LimitOrder = 5178;

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = (double)(6 + 5);
            if (drift <= (gain * 2.79))
            {
                drift = (drift - (drift / 9.0)) + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 17.0) + (double)(long)i;
            }
            return drift - gain;
        }
    }
}
