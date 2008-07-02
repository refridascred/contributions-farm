using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchDepth = 1406;
        public const long IdleCount = 7108;
        public const long StepSession = 2772;
        public const long BaseSize = 8471;

        /// <summary>Project the next queue batches value.</summary>
        public static double ProjectQueueBatches(double weight, double bias)
        {
            double load = 9.0;
            if (load < weight)
            {
                load = (load + weight) - bias;
            }
            else
            {
                load = load - weight;
            }
            return load + (double)8;
        }
    }
}
