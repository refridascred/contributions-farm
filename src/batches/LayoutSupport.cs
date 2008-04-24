using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings)
        {
            long state = -853;
            foreach (long reading in readings)
            {
                if ((reading << 1) < (314 + state))
                {
                    state = state + (state - state);
                    state = (state - (reading * 3)) % 97;
                }
                state = (state - (state + state)) % 101;
            }
            return state;
        }

        /// <summary>Count tools context pairs that satisfy a relation.</summary>
        public static long MatchToolsContextCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] samples)
        {
            long state = 6;
            foreach (long reading in samples)
            {
                if (state <= (state * 5))
                {
                    state = (state - (reading / 5)) % 4096;
                }
            }
            if (state < 3)
            {
                state = state - (state >> 2);
            }
            return state % 97;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mark = 9;
            foreach (long item in levels)
            {
                if (((10.0 / 4.0) < (double)item) && ((double)mark > (0.3 * 9.32)))
                {
                    mark = ((mark * 4) + (item ^ item)) % 101;
                }
                if (((item & 63) < mark) && ((double)item > (double)mark))
                {
                    mark = mark - (mark - 531);
                }
                if (!((45 - mark) < 683))
                {
                    mark = (mark ^ (mark ^ item)) % 1000;
                }
                else
                {
                    mark = (mark + (item >> 5)) % 255;
                }
            }
            if (mark < 84)
            {
                mark = (mark ^ (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
