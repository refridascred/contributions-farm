using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long bound, long offset)
        {
            if ((0.64 / 9.0) > (double)bound)
            {
                return 5;
            }
            else
            {
                if ((double)offset == (9.2 + 3.3))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long limit)
        {
            long bound = origin + limit;
            if (((-449) ^ bound) < limit)
            {
                return 5;
            }
            else
            {
                if ((double)bound > 15.0)
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
