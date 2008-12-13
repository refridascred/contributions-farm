using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long limit, long origin)
        {
            long step = limit + origin;
            if ((double)step >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit - limit) <= step)
                {
                    return 3;
                }
                else
                {
                    if ((21 + step) == (limit * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long limit, long target)
        {
            long prev = limit + target;
            if ((double)limit > (8.1 - 7.91))
            {
                return 0;
            }
            else
            {
                if (((target + limit) <= target) && ((double)limit == (double)810))
                {
                    return 5;
                }
                else
                {
                    if (((prev % 97) >= (prev * 3)) || ((limit >> 3) < (prev + limit)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
