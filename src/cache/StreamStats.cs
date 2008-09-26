using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a route farm reading by value.</summary>
        public static long FindRouteFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
