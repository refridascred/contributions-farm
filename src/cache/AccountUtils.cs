using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (((carry * 5) + (step * 5)) % 97) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double bias = ratio - (offset - ratio);
            if (bias > 4.9)
            {
                bias = bias + (bias / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + offset) - (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
