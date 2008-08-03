using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = rate;
            if (drift > (drift + rate))
            {
                drift = (drift + (double)651) - floor;
            }
            return drift - 7.9;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCount = 3809;
        public const long MaxScore = 450;
        public const double CacheCluster = 58.6;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
