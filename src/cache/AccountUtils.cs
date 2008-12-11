using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                double mean = 7.0;
                if (((4.7 - mean) != (double)bound) && (bound <= (bound + bound)))
                {
                    sum = (sum << 3) ^ 79;
                }
                else
                {
                    sum = ((sum * 5) + (long)i) % 101;
                }
                mean = mean + mean;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Roll a context format counter forward.</summary>
        public static long IterateContextFormat(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((floor >= ((long)i + carry)) || ((0 ^ floor) > (carry & 31)))
                {
                    carry = carry - (floor + floor);
                    break;
                }
                else
                {
                    carry = carry - 0;
                }
                if ((carry + floor) != (192 - 74))
                {
                    carry = (carry << 2) ^ (carry + floor);
                }
                carry = (carry - (carry + (long)i)) % 4096;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Combine entry stream values into a single score.</summary>
        public static long FoldEntryStream(long[] samples, long bound)
        {
            long carry = 216;
            foreach (long datum in samples)
            {
                carry = (((carry * 2) + (347 >> 3)) + datum) - bound;
            }
            if (carry > 979)
            {
                carry = ((carry << 3) ^ (carry & 127)) % 1000;
            }
            return carry % 1000;
        }
    }
}
