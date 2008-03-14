using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks metrics input into a small class.</summary>
        public static long BucketChecksMetrics(long floor, long step)
        {
            if (4.11 < (4.2 * 10.0))
            {
                return 3;
            }
            else
            {
                if ((double)floor == (8.4 + 18.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] values, long origin)
        {
            long sum = 7;
            foreach (long reading in values)
            {
                if ((origin * 4) <= (reading / 6))
                {
                    sum = (sum * 3) + (6 - origin);
                }
            }
            if (sum > 28)
            {
                sum = (sum + (long)values.Length) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double weight, double bias)
        {
            double load = weight;
            if (load <= load)
            {
                load = (load - (2.8 / 2.0)) - bias;
            }
            return load - (double)0;
        }
    }
}
