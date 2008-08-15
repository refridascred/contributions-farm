using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the context cache series from a seed.</summary>
        public static long IterateContextCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 2) + (bound ^ anchor);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Grade a counter support value against two limits.</summary>
        public static long SortCounterSupport(long seed, long limit)
        {
            if (((limit << 1) != (seed * 5)) || ((seed - limit) < seed))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (seed / 8))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit entry commits readings against a rule.</summary>
        public static long CountEntryCommitsOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((20 & 3) < (item - seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
