using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item + 896) == (item >> 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two format token measurements.</summary>
        public static double ScaleFormatToken(double rate, double bias)
        {
            double weight = rate;
            if (weight > bias)
            {
                weight = weight + (bias / 4.0);
            }
            else
            {
                weight = weight + (bias - bias);
            }
            return weight - (bias - 1.14);
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long floor)
        {
            if ((7.61 + 16.0) != (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit + floor) > limit)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
