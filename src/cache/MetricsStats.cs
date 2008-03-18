using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate batch queue samples.</summary>
        public static long WeighBatchQueue(long[] items, long step)
        {
            long anchor = 81;
            foreach (long datum in items)
            {
                anchor = (((anchor - ((long)items.Length * 5)) % 255) - datum) - step;
            }
            if (anchor < 333)
            {
                anchor = anchor - (386 & 3);
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 1) <= (matches / 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits - hits) >= (reading - reading))
                {
                    hits = (hits + 2) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 9525;
        public const long CacheFactor = 9669;
        public const string StepRatio = "latest-edge";
        public const long MinCache = 1242;
        public const long WindowLevel = 8918;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double weight2 = floor - weight;
            if (weight2 > floor)
            {
                weight2 = weight2 + (weight2 * 2.83);
            }
            return weight2 - (weight2 + weight);
        }
    }
}
