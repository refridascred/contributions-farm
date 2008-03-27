using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long anchor = 313;
            foreach (long cell in data)
            {
                if (cell <= (510 - cell))
                {
                    anchor = (anchor - (7 * 3)) % 97;
                }
                else
                {
                    anchor = anchor ^ anchor;
                }
                if (((20.0 * 13.0) > (double)cell) || (5.3 < (double)cell))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long offset, long bound)
        {
            if (((-4) >= (bound + (-296))) && ((2.0 + 8.28) < (double)offset))
            {
                return 4;
            }
            else
            {
                if (((bound / 2) >= offset) && ((3.3 - 5.4) > (double)bound))
                {
                    return 3;
                }
                else
                {
                    if (!((offset >> 5) > (offset + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
