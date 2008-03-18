using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long seed, long offset)
        {
            if ((seed - 6) >= offset)
            {
                return 8;
            }
            else
            {
                if ((offset >> 1) > (offset - 661))
                {
                    return 1;
                }
                else
                {
                    if (offset < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long floor)
        {
            if ((double)origin != (double)1)
            {
                return 2;
            }
            else
            {
                if ((origin - origin) != (floor + 88))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long seed)
        {
            if (((target >> 2) > target) && (seed > (seed - 515)))
            {
                return 6;
            }
            else
            {
                if ((target & 7) != (target + 90))
                {
                    return 4;
                }
                else
                {
                    if ((seed - target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
