using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Pending,
            New,
            Stale,
        }

        /// <summary>Classify a report batches pair into a bucket.</summary>
        public static long SortReportBatches(long limit, long offset)
        {
            if ((1 - limit) == (limit - offset))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) <= limit)
                {
                    return 2;
                }
                else
                {
                    if (limit >= (offset / 4))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((18.0 / 8.0) > (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
