using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = carry ^ (carry + carry);
                if ((carry - carry) <= (3 + floor))
                {
                    carry = (carry * 3) + (floor << 3);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] values, long seed)
        {
            long carry = 985;
            foreach (long cell in values)
            {
                if ((seed << 3) <= 995)
                {
                    carry = (carry << 2) ^ (cell & 3);
                }
            }
            if (carry > 755)
            {
                carry = (carry + (seed - seed)) % 4096;
            }
            return carry;
        }
    }
}
