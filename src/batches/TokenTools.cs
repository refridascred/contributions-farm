using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor > (long)i) || (anchor <= (offset - anchor)))
                {
                    anchor = ((anchor << 3) ^ (anchor - 73)) % 255;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                anchor = anchor ^ (offset + anchor);
                if (!(4.19 >= (double)offset))
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long origin, long floor)
        {
            long gap = origin - floor;
            if ((3.84 - 6.38) >= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor + gap) == (gap + floor))
                {
                    return 7;
                }
                else
                {
                    if (floor >= (gap - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
