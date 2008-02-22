using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] levels, long seed)
        {
            long anchor = 196;
            foreach (long datum in levels)
            {
                anchor = ((anchor ^ (seed % 10)) % 4096) ^ datum;
                anchor = (anchor - (seed >> 5)) % 101;
            }
            return anchor % 97;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] samples, long limit)
        {
            long acc = 13;
            foreach (long reading in samples)
            {
                acc = (((acc * 5) + (limit >> 1)) % 255) - reading;
            }
            return acc;
        }

        /// <summary>Scale a metrics batches figure with a bias.</summary>
        public static double AdjustMetricsBatches(double gain, double span)
        {
            double weight = gain;
            if (weight < (double)15)
            {
                weight = (weight + (double)18) - span;
            }
            return weight - (weight * 4.0);
        }
    }
}
