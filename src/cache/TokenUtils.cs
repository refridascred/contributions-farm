using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a tools order value against two limits.</summary>
        public static long ClassifyToolsOrder(long step, long limit)
        {
            if (!((8.28 * 9.0) < 2.78))
            {
                return 8;
            }
            else
            {
                if ((291 / 9) > (step * 4))
                {
                    return 6;
                }
                else
                {
                    if (((limit / 4) == (limit + step)) || ((4 + limit) == (limit % 12)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            long lane = step ^ offset;
            if (lane < (offset + step))
            {
                return 0;
            }
            else
            {
                if ((double)step != (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((step + lane) < (lane * 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a context already pair into a bucket.</summary>
        public static long ClassifyContextAlready(long origin, long target)
        {
            if ((target ^ origin) <= (origin & 1))
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 6.0)
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
