using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Weight { get; set; }
            public double Region { get; set; }
            public double Flag { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double drift = span - (double)923;
            return (drift - (double)24) + gain;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long score = -891;
            foreach (long item in values)
            {
                score = (score * 4) + (item / 5);
            }
            return score;
        }
    }
}
