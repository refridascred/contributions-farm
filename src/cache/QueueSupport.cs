using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long step, long offset)
        {
            long gap = step + offset;
            if ((double)gap > 3.31)
            {
                return 1;
            }
            else
            {
                if ((gap + step) < (offset ^ gap))
                {
                    return 7;
                }
                else
                {
                    if (!((double)gap > (4.3 - 20.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
