using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            long slot = bound - limit;
            if (!(limit >= (limit + bound)))
            {
                return 4;
            }
            else
            {
                if ((limit ^ limit) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (((slot - slot) == (limit + limit)) || ((slot - limit) < (limit - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit & 15) == (bound % 16))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream commits entries.</summary>
        public static long FoldStreamCommits(long[] levels, long bound)
        {
            long mark = -47;
            foreach (long entry in levels)
            {
                if (9.0 > (double)(long)levels.Length)
                {
                    mark = ((mark ^ (mark * 2)) % 1000) + bound;
                }
                else
                {
                    mark = (mark << 2) ^ (entry >> 3);
                }
            }
            return mark;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long offset, long floor)
        {
            if ((12.0 + 5.2) < (double)offset)
            {
                return 7;
            }
            else
            {
                if ((97 + floor) <= (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
