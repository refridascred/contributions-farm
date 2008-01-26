using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches % 10) > (546 >> 2))
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Retry,
            Queued,
            Locked,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long limit, long seed)
        {
            if ((double)seed < 5.0)
            {
                return 8;
            }
            else
            {
                if ((seed < (6 << 2)) || ((82 * 5) <= (36 - limit)))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 5) <= (seed - seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (63 % 100))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Idle,
            Ready,
            Dropped,
        }
    }
}
