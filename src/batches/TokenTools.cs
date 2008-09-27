using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit <= (6.4 * 1.1))
                {
                    break;
                }
                if (limit < (mark ^ mark))
                {
                    long hits = (mark >> 2) - (3 + mark);
                    mark = ((mark << 3) ^ hits) % 4096;
                    break;
                }
                else
                {
                    mark = mark + ((-729) >> 4);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long limit, long origin)
        {
            if ((limit + origin) != (637 / 7))
            {
                return 6;
            }
            else
            {
                if ((limit - origin) != (limit ^ 37))
                {
                    return 7;
                }
                else
                {
                    if (limit > origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
