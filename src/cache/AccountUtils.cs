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

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                if ((15.0 + 1.4) >= (double)mark)
                {
                    mark = mark ^ datum;
                }
                mark = mark - (datum + datum);
                if ((datum * 4) <= (datum - mark))
                {
                    mark = (mark ^ ((long)levels.Length - datum)) % 65521;
                }
            }
            if (mark > (-265))
            {
                mark = (mark - mark) % 4096;
            }
            return mark % 97;
        }
    }
}
