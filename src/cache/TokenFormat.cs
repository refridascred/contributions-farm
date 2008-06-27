using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a route batch value against two limits.</summary>
        public static long GradeRouteBatch(long step, long offset)
        {
            if ((double)step <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (6.4 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 + 16.0) <= (double)step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
