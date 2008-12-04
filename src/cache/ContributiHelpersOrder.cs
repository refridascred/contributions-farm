using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = (total << 2) ^ (2 / 8);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double weight, double bias)
        {
            double drift = bias;
            return drift - weight;
        }
    }
}
