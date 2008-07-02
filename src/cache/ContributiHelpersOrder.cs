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

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Queued,
            Idle,
            Ready,
        }

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
