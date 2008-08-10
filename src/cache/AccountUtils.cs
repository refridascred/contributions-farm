using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 < (8.0 * 12.0))
            {
                rate2 = (rate2 + floor) - rate;
            }
            else
            {
                rate2 = rate2 + rate2;
            }
            return rate2 - floor;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long target)
        {
            long sum = 44;
            foreach (long sample in levels)
            {
                sum = ((sum << 3) ^ (sample >> 1)) % 255;
                if (sample >= (sample - target))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
