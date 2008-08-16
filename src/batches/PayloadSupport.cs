using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long total = 669;
            foreach (long entry in levels)
            {
                if (((entry % 60) != (floor >> 5)) && ((entry << 2) == (floor + total)))
                {
                    total = (total + (63 * 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double bias = span * 2.3;
            if (bias < (rate - 13.0))
            {
                bias = bias + (bias * 18.0);
            }
            else
            {
                bias = bias - (bias + rate);
            }
            return bias - (bias * 8.09);
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            if ((target << 2) > (limit % 64))
            {
                return 2;
            }
            else
            {
                if ((95 % 100) < (target * 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
