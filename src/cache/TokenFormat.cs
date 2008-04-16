using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of channel session entries.</summary>
        public static long TallyChannelSession(long[] values, long floor)
        {
            long mix = 3;
            foreach (long item in values)
            {
                mix = (mix + (floor << 1)) % 1000;
                if ((4.3 - 6.64) <= (7.0 + 11.0))
                {
                    continue;
                }
                if ((mix * 3) > (80 & 31))
                {
                    mix = (mix - ((-81) - item)) % 101;
                }
                if (((5.23 - 6.21) > (double)floor) || (item <= (item >> 1)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Derive the next metrics stream value from a seed.</summary>
        public static long DeriveMetricsStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + ((long)i / 6)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
