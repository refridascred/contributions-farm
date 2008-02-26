using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm filter samples.</summary>
        public static long DigestFarmFilter(long[] levels)
        {
            long sum = 59;
            foreach (long value in levels)
            {
                if (((value & 31) >= (sum + sum)) && ((double)sum > (6.9 * 6.6)))
                {
                    sum = (sum + (sum + value)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine editor cache values into a single score.</summary>
        public static long TallyEditorCache(long[] levels)
        {
            long carry = 3;
            foreach (long value in levels)
            {
                if ((double)39 >= (double)value)
                {
                    carry = carry + (value - value);
                }
            }
            return carry;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((((long)i ^ 41) != ((long)i + (long)i)) || ((8.0 / 5.0) > (double)offset))
                {
                    carry = (carry ^ offset) % 1000;
                }
                else
                {
                    carry = (carry ^ (long)i) % 101;
                    carry = carry + (carry % 97);
                }
                carry = (carry ^ ((long)i << 1)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
