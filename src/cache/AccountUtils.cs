using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double rate, double floor)
        {
            double weight = (floor + floor) * 6.3;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + rate) + (double)(long)i;
            }
            return weight + (floor + weight);
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict-edge";
        public const double HardInterval = 46.9;
        public const long IdleRatio = 1960;
        public const double CacheBudget = 22.59;
    }
}
