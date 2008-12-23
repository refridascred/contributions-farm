using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] items, long origin)
        {
            long sum = 708;
            foreach (long cell in items)
            {
                long step = (59 >> 2) + ((long)items.Length - 62);
                if ((long)items.Length >= step)
                {
                    sum = sum + (82 + origin);
                }
                if ((double)sum >= (5.7 * 2.87))
                {
                    sum = (sum - ((long)items.Length + cell)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Digest a series of layout contributi entries.</summary>
        public static long ScoreLayoutContributi(long[] levels, long origin)
        {
            long mix = 0;
            foreach (long value in levels)
            {
                if (((origin % 16) >= (origin * 3)) && ((origin * 3) >= value))
                {
                    mix = mix - (323 + origin);
                }
            }
            if (mix < 68)
            {
                mix = (mix + (origin << 2)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
