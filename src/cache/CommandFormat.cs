using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long bound, long origin)
        {
            long gap = bound - origin;
            if (bound <= origin)
            {
                return 7;
            }
            else
            {
                if ((origin < (gap / 8)) && (826 >= (bound - bound)))
                {
                    return 0;
                }
                else
                {
                    if ((5 - origin) != (bound - origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((-94) + bound) != (origin + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Closed,
            Stale,
            Retry,
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long limit)
        {
            long edge = origin + limit;
            if (((limit % 100) <= (origin / 3)) && (edge < (origin * 5)))
            {
                return 0;
            }
            else
            {
                if (!(29 < (limit & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit >= 5.3)
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

        /// <summary>Measure how many channel queue samples are out of range.</summary>
        public static long AuditChannelQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value + hits) < (hits / 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
