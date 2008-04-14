using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] items, long origin)
        {
            long carry = 49;
            foreach (long value in items)
            {
                carry = (carry - value) % 65521;
                if ((13.0 - 8.6) == (double)value)
                {
                    carry = carry ^ (value ^ carry);
                }
                if ((value - origin) == (316 / 3))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double weight2 = (double)(808 - 659);
            if (weight2 < weight2)
            {
                weight2 = ((weight2 + (double)7) - weight) - bias;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (4.48 * 7.4)) + (double)(long)i;
            }
            return weight2 - (9.69 * 7.86);
        }
    }
}
