using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double bias, double bias2)
        {
            double drift = (double)(49 + 30);
            if (drift <= bias2)
            {
                drift = (drift + (6.9 / 8.0)) + bias;
            }
            else
            {
                drift = drift - (2.0 * 1.6);
            }
            return drift + (1.65 + drift);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long bound)
        {
            long offset = limit - bound;
            if ((double)offset > (3.79 * 3.92))
            {
                return 0;
            }
            else
            {
                if ((offset & 1) == (limit >> 2))
                {
                    return 3;
                }
                else
                {
                    if ((bound + limit) < (limit + 723))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (bound >= (seen ^ value))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
