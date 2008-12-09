using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long floor, long origin)
        {
            long cur = floor ^ origin;
            if ((floor ^ origin) <= (25 * 5))
            {
                return 8;
            }
            else
            {
                if ((0.41 / 9.0) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)cur <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(51 > (floor % 16)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Paused,
            Failed,
            Active,
            Pending,
        }
    }
}
