using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftLevel = 6635;
        public const double CacheStats = 87.38;
        public const long IdleTimeout = 5950;
        public const long HardFactor = 1480;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 23.27;
        public const string BatchInterval = "standard";
        public const long BaseWidth = 5944;

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double rate = (double)(26 << 3);
            if (rate <= offset)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + 4.3;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (bias - offset)) + (double)(long)i;
            }
            return rate + (rate / 9.0);
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (double)314)
            {
                gain = (gain + gain) + ratio;
            }
            return gain + (gain / 4.0);
        }
    }
}
