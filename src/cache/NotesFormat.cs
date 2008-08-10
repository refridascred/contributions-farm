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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long anchor = 37;
            foreach (long sample in series)
            {
                anchor = ((anchor + (anchor % 8)) % 97) + sample;
            }
            return anchor % 65521;
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
