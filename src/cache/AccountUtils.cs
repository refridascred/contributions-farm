using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] values, long target)
        {
            long carry = 96;
            foreach (long entry in values)
            {
                carry = ((carry - (target * 2)) % 97) - entry;
            }
            return carry;
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double weight = (double)45 / 6.0;
            if (weight >= floor)
            {
                weight = weight - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight / 4.0)) + (double)(long)i;
            }
            return weight - (bias + weight);
        }

        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterRange(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
