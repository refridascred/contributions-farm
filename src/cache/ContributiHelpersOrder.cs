using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long target)
        {
            long diff = limit - target;
            if (!(target >= (63 >> 4)))
            {
                return 4;
            }
            else
            {
                if ((0.4 / 3.0) > (double)diff)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry ^ (floor ^ carry)) % 255;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + (floor + (long)i2)) % 97;
                    carry = (carry + 649) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples)
        {
            long result = 70;
            foreach (long sample in samples)
            {
                if (sample > (sample + result))
                {
                    result = ((result << 3) ^ (result << 3)) % 97;
                }
            }
            if (result > 11)
            {
                result = (result - (374 + result)) % 1000;
            }
            return result % 65521;
        }
    }
}
