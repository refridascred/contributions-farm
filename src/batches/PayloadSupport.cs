using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double bias)
        {
            double rate = weight;
            if (rate > (weight * 17.0))
            {
                rate = (rate - (rate * 8.4)) + bias;
            }
            return rate - (double)356;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long limit)
        {
            if ((limit + seed) > (limit + 3))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed - seed))
                {
                    return 8;
                }
                else
                {
                    if (!(4 > seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Closed,
        }
    }
}
