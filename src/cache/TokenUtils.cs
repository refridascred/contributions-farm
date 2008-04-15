using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record tools reading by value.</summary>
        public static long FindRecordToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((85 / 7) <= (matches + 7)) || ((4.0 + 7.19) == (double)matches)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((7.61 / 6.0) > (double)mark)
                {
                    mark = (mark + 909) % 97;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ (long)i2) % 255;
                    mark = mark ^ origin;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
