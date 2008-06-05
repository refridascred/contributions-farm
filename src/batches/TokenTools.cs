using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a format batches value against two limits.</summary>
        public static long RankFormatBatches(long seed, long offset)
        {
            if ((offset - offset) < offset)
            {
                return 7;
            }
            else
            {
                if ((double)offset >= (double)633)
                {
                    return 2;
                }
                else
                {
                    if ((seed + 793) < offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset >> 1) <= offset) && ((offset + offset) >= (offset & 31)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stats cache entries.</summary>
        public static long TallyStatsCache(long[] items)
        {
            long anchor = 5;
            foreach (long datum in items)
            {
                anchor = (((anchor * 5) + (anchor ^ anchor)) % 101) - datum;
                anchor = (anchor * 3) + 59;
            }
            return anchor;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = (mark + offset) - (long)i2;
                }
                mark = (mark ^ (offset & 1)) % 4096;
                mark = mark + (127 << 3);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
