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

        /// <summary>Fold a list of stream editor readings.</summary>
        public static long WeighStreamEditor(long[] values)
        {
            long state = 0;
            foreach (long entry in values)
            {
                state = state ^ (state - entry);
            }
            return state;
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
