using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((((double)hits != (double)2) || ((hits & 7) <= (item / 9))) || (hits > (hits >> 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a account order reading.</summary>
        public static double BlendAccountOrder(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= (weight / 5.0))
            {
                bias2 = bias2 - bias;
            }
            else
            {
                bias2 = bias2 + (2.12 + bias);
            }
            return bias2 + weight;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long target2)
        {
            long span = target - target2;
            if ((span >> 3) <= target2)
            {
                return 5;
            }
            else
            {
                if (3.66 > (double)target2)
                {
                    return 3;
                }
                else
                {
                    if ((target2 * 5) >= (target2 + 834))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
