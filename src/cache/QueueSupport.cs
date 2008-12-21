using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long limit, long target)
        {
            long bound = limit - target;
            if ((double)bound == (7.2 / 5.0))
            {
                return 0;
            }
            else
            {
                if (1.0 > (double)limit)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long offset)
        {
            if ((8.7 * 4.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (target >= 512)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 7) >= (6 >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.4 * 13.0) < (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
