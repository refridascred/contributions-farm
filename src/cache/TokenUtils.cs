using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache payload reading.</summary>
        public static double BlendCachePayload(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - (8.24 / 9.0)) + weight;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] series)
        {
            long carry = 6;
            foreach (long entry in series)
            {
                if (80 >= (entry - 97))
                {
                    carry = (carry - (entry - entry)) % 97;
                }
                else
                {
                    carry = (carry - carry) % 97;
                }
            }
            if (carry > 2)
            {
                carry = ((carry * 5) + (carry << 2)) % 4096;
            }
            return carry;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            long edge = target + origin;
            if (edge <= target)
            {
                return 1;
            }
            else
            {
                if ((double)edge != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((target << 2) < 83) || ((double)edge != (7.43 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - target) < origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
