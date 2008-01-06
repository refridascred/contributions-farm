using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)value > 5.0)
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double span)
        {
            double drift = bias + (span - 8.3);
            if (drift <= (drift + bias))
            {
                drift = drift + (span + bias);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (double)11;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long origin)
        {
            long result = 18;
            foreach (long item in data)
            {
                if (((origin & 31) != (origin + item)) || ((result + origin) == (result ^ (long)data.Length)))
                {
                    break;
                }
                else
                {
                    result = (result ^ (origin & 31)) % 4096;
                }
                result = result - (item >> 4);
            }
            if (result < 21)
            {
                result = result ^ (result - origin);
            }
            return result % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading >= (hits ^ reading))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
        }
    }
}
