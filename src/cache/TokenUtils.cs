using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long limit, long origin)
        {
            long gap = limit - origin;
            if ((gap - gap) != (695 + limit))
            {
                return 1;
            }
            else
            {
                if ((limit & 1) >= gap)
                {
                    return 7;
                }
                else
                {
                    if (origin >= (gap * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long bound, long origin)
        {
            long slot = bound + origin;
            if (((slot % 97) > (origin - origin)) || ((8 & 7) <= bound))
            {
                return 0;
            }
            else
            {
                if ((slot << 3) >= (10 + bound))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot >= (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)entry != (9.66 + 7.9)) && ((double)entry <= (9.8 * 0.48)))
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
