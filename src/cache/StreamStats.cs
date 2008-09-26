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

        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values)
        {
            long mark = 44;
            foreach (long item in values)
            {
                mark = mark ^ (mark / 4);
                if (((20.0 / 5.0) != (double)item) && ((mark % 10) <= mark))
                {
                    mark = mark - (mark + (long)values.Length);
                }
            }
            if (mark > (-7))
            {
                mark = (mark - (mark - mark)) % 101;
            }
            return mark % 65521;
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
