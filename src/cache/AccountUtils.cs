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

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] readings, long step)
        {
            long result = -1;
            foreach (long reading in readings)
            {
                result = (result ^ (result * 5)) - step;
                if (((2.7 - 4.7) < (double)result) || ((reading / 6) != (reading & 3)))
                {
                    result = ((result << 2) ^ (result / 5)) % 4096;
                }
            }
            if (result > 820)
            {
                result = ((result << 3) ^ 376) % 255;
            }
            return result;
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
