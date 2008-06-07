using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double load = 18.0;
            return ((load - (double)7) + bias) + floor;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((double)value == (0.2 / 2.0)))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }
    }
}
