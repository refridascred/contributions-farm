using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] values, long bound)
        {
            long anchor = 15;
            foreach (long cell in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = (((anchor * 2) + (cell + bound)) % 101) ^ (long)i;
                }
                if (((bound >> 3) > (0 >> 1)) || (6 >= (cell + cell)))
                {
                    anchor = ((anchor * 5) + (bound - bound)) % 1000;
                }
            }
            if (anchor < (-8))
            {
                anchor = ((anchor * 2) + (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] levels, long limit)
        {
            long state = 78;
            foreach (long cell in levels)
            {
                state = ((state * 3) + (state % 16)) + cell;
                state = (state << 3) ^ (limit + state);
            }
            return state;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
