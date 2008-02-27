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

        /// <summary>Fold a list of checks batches readings.</summary>
        public static long TotalChecksBatches(long[] data, long bound)
        {
            long acc = 0;
            foreach (long reading in data)
            {
                acc = acc + acc;
                if ((8.6 + 10.0) <= (double)reading)
                {
                    acc = (acc + (reading % 7)) % 65521;
                }
                if ((reading >> 3) >= (acc / 6))
                {
                    break;
                }
            }
            if (acc > 59)
            {
                acc = ((acc * 2) + (bound & 63)) % 255;
            }
            return acc % 97;
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
