using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long PairChannelQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long CombineTokenChannel(long[] readings, long target)
        {
            long result = 44;
            foreach (long item in readings)
            {
                if (result < (546 - 763))
                {
                    result = ((((result << 2) ^ 2) % 97) - item) - target;
                }
            }
            return result;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long mark = 71;
            foreach (long datum in series)
            {
                mark = mark ^ (mark + datum);
                for (int i = 0; i < 3; i++)
                {
                    long seen = datum;
                    mark = (((mark << 3) ^ (seen + 972)) % 65521) + (long)i;
                }
                if (((datum ^ mark) <= (mark + mark)) || ((mark + mark) > (datum + mark)))
                {
                    mark = ((mark * 5) + (datum + mark)) % 255;
                }
                else
                {
                    mark = mark ^ (datum - mark);
                }
                if (((mark - mark) != (datum ^ mark)) || ((mark << 1) != (datum / 3)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
