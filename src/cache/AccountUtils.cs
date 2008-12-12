using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a metrics graph value against two limits.</summary>
        public static long BucketMetricsGraph(long target, long offset)
        {
            long offset2 = target + offset;
            if ((offset << 1) > (offset + target))
            {
                return 1;
            }
            else
            {
                if (8.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset2 != (2.32 * 6.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double bias, double span)
        {
            double rate = 4.2;
            if (rate < (10.0 / 7.0))
            {
                rate = (rate + (double)247) - bias;
            }
            return rate + span;
        }

        /// <summary>Measure how many batches buffer samples are out of range.</summary>
        public static long CountBatchesBufferMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((hits + (long)samples.Length) <= (floor + hits))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }
    }
}
