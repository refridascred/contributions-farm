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

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
