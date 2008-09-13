using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the support cluster series from a seed.</summary>
        public static long StepSupportCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 10; i++)
            {
                state = state + (state + state);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
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
