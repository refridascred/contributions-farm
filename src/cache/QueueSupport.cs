using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a metrics tools pair into a bucket.</summary>
        public static long BucketMetricsTools(long seed, long target)
        {
            if ((seed & 255) >= (seed / 5))
            {
                return 7;
            }
            else
            {
                if ((target >= (target ^ target)) && ((seed * 2) <= (seed + target)))
                {
                    return 8;
                }
                else
                {
                    if (((target - 993) == (target + 63)) && ((double)target != (double)(-2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target / 3) > (seed % 16))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry <= (entry & 15))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double bias2)
        {
            double scale = (double)81;
            if (scale < (double)498)
            {
                scale = (scale + (double)40) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (bias2 * 3.31)) + (double)(long)i;
            }
            return scale + (double)98;
        }
    }
}
