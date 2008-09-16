using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Active,
            Synced,
            Closed,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double mean = bias;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - (bias * 4.88)) + (double)(long)i) + ratio;
            }
            return mean - (double)714;
        }
    }
}
