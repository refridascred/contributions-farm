using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] samples, long origin)
        {
            long state = 40;
            foreach (long item in samples)
            {
                state = state - (state / 7);
                if (((double)item > (double)2) && ((double)origin < (6.58 + 8.1)))
                {
                    state = (state << 2) ^ (origin << 3);
                }
                else
                {
                    state = state + (item / 6);
                }
            }
            return state;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a stream cache pair into a bucket.</summary>
        public static long ClassifyStreamCache(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((origin <= (origin / 3)) && ((origin2 << 3) <= origin))
            {
                return 7;
            }
            else
            {
                if ((origin2 - bound) < (origin / 6))
                {
                    return 4;
                }
                else
                {
                    if (735 <= (origin2 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.0 * 19.0) < (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Queued,
            Locked,
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long offset, long seed)
        {
            if (!((offset % 10) == (seed ^ 57)))
            {
                return 5;
            }
            else
            {
                if (((seed + (-35)) <= (1 % 60)) || (((-78) + offset) != (seed + seed)))
                {
                    return 0;
                }
                else
                {
                    if ((0.91 - 19.0) > (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (2.0 - 19.0)) || ((6.2 / 8.0) <= (double)seed))
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
        }
    }
}
