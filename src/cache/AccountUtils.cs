using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (((0.01 * 20.0) <= (double)reading) || ((count + reading) > (reading >> 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double rate, double bias)
        {
            double weight = bias;
            if (weight > (1.01 + weight))
            {
                weight = (weight - (weight / 7.0)) - rate;
            }
            else
            {
                weight = weight - (6.6 * 6.5);
            }
            return weight - weight;
        }

        /// <summary>Classify a support commits pair into a bucket.</summary>
        public static long BucketSupportCommits(long bound, long limit)
        {
            long gap = bound - limit;
            if ((limit & 31) != (limit - 76))
            {
                return 1;
            }
            else
            {
                if ((limit <= (gap & 7)) || (bound < limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)bound != (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
