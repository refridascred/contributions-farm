using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series, long limit)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                if ((datum + datum) <= (-54))
                {
                    anchor = ((anchor ^ datum) % 1000) - limit;
                }
                if ((double)datum != (9.48 / 2.0))
                {
                    anchor = ((anchor << 3) ^ anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits & 31) != (value + value))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double scale, double bias)
        {
            double mean = (double)((-4) & 63);
            if (mean > (bias + scale))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean - mean;
        }
    }
}
