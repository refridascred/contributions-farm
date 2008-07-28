using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5997;
        public const long MaxSession = 3540;
        public const string LimitSize = "cached-1";
        public const double BatchSession = 73.23;

        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "stable-1";
        public const long HardRatio = 8406;
        public const long LimitWidth = 4631;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ProjectQueue(double scale, double bias)
        {
            double drift = 9.7;
            if (drift <= bias)
            {
                drift = (drift + (double)(-23)) - scale;
            }
            else
            {
                drift = drift + 5.34;
            }
            return drift - (drift * 20.0);
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
