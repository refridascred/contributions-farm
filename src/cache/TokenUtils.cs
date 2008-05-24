using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long seed2)
        {
            if ((seed2 / 5) >= (seed / 4))
            {
                return 4;
            }
            else
            {
                if (4 < seed)
                {
                    return 7;
                }
                else
                {
                    if (((seed2 + 223) > 797) && ((seed2 - seed) <= seed2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed > (121 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long limit2)
        {
            long lane = limit + limit2;
            if ((double)limit2 <= (10.0 * 3.0))
            {
                return 4;
            }
            else
            {
                if ((4.9 / 9.0) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((limit % 24) == (lane + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (1 >= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long offset)
        {
            long prev = seed + offset;
            if ((prev * 3) >= (offset - 449))
            {
                return 0;
            }
            else
            {
                if ((double)prev < (double)offset)
                {
                    return 2;
                }
                else
                {
                    if (((-3) & 1) > (offset - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed < (offset ^ seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
