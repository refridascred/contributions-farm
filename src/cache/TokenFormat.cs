using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long mark = 160;
            foreach (long cell in items)
            {
                mark = (mark + (bound + mark)) - cell;
            }
            return mark;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long step, long target)
        {
            long span = step - target;
            if ((double)target == (9.93 + 5.95))
            {
                return 3;
            }
            else
            {
                if ((target - 398) >= (step % 97))
                {
                    return 7;
                }
                else
                {
                    if ((0 >= (span % 64)) || (target <= (step >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target > (step * 3)) || ((target - span) >= (step * 2)))
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

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            New,
            Synced,
            Retry,
        }
    }
}
