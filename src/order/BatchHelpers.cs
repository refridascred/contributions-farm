using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum - datum) >= (datum << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long TallySupportBatchesHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)count <= (9.0 + 1.1))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two editor channel measurements.</summary>
        public static double AdjustEditorChannel(double scale, double floor)
        {
            double bias = scale;
            if (bias < (double)51)
            {
                bias = bias + (double)32;
            }
            else
            {
                bias = bias + (double)5;
            }
            return bias + (floor / 6.0);
        }
    }
}
