using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double offset)
        {
            double drift = (double)(543 + 1);
            return (drift + (scale - 4.24)) + offset;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
