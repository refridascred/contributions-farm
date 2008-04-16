using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((offset - 12) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long offset)
        {
            long mark = 38;
            foreach (long value in values)
            {
                if ((520 > (offset - offset)) || ((8 % 3) == (value % 97)))
                {
                    mark = (mark ^ (24 + mark)) % 65521;
                }
            }
            if (mark > 555)
            {
                mark = (mark * 2) + (mark - mark);
            }
            return mark;
        }
    }
}
