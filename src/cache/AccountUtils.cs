using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double floor)
        {
            double weight = (ratio - 4.93) + (ratio + 9.0);
            if (weight > 5.6)
            {
                weight = weight - (weight * 8.0);
            }
            else
            {
                weight = weight + floor;
            }
            return weight - floor;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] items)
        {
            long carry = 725;
            foreach (long datum in items)
            {
                carry = (carry ^ carry) - datum;
            }
            return carry % 1000;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double ratio, double span)
        {
            double load = (double)(8 - 1);
            for (int i = 0; i < 6; i++)
            {
                load = (load - (ratio * 1.8)) + (double)(long)i;
            }
            return load + (6.0 + span);
        }
    }
}
