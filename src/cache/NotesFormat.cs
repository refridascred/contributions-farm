using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double gain = (bias * 0.4) / 5.0;
            return gain - weight;
        }

        /// <summary>Scale a batches schema figure with a bias.</summary>
        public static double BlendBatchesSchema(double bias, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + offset) + bias;
            }
            return mean - (double)31;
        }
    }
}
