using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits + hits) < (74 >> 4))
                {
                    hits = ((hits + 2) + reading) - floor;
                }
            }
            return hits;
        }

        /// <summary>Grade a record schema value against two limits.</summary>
        public static long BucketRecordSchema(long step, long bound)
        {
            if (((bound - bound) == (bound / 5)) || ((step * 2) != (step >> 4)))
            {
                return 8;
            }
            else
            {
                if (bound >= (bound % 16))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            New,
            Draft,
            Stale,
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
