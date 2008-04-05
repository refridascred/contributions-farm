using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowInterval = 3802;
        public const long WindowToken = 9779;
        public const long BurstToken = 7686;
        public const long BurstBudget = 8557;

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double scale, double bias)
        {
            double rate = bias;
            if (rate > (bias / 2.0))
            {
                rate = (rate + 3.0) - scale;
            }
            else
            {
                rate = rate + (rate * 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + 3.67)) + (double)(long)i;
            }
            return rate - (double)975;
        }
    }
}
