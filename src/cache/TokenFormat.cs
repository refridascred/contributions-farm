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

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long origin)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                if (((origin - origin) > cell) || ((sum << 2) > (51 + sum)))
                {
                    sum = (sum - origin) % 255;
                }
            }
            return sum % 97;
        }
    }
}
