using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Classify a context graph pair into a bucket.</summary>
        public static long SortContextGraph(long bound, long bound2)
        {
            if ((double)bound > (double)bound2)
            {
                return 5;
            }
            else
            {
                if (!((2.3 - 1.8) >= (double)bound2))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) == (count % 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Pending,
            Stale,
            Queued,
        }

        /// <summary>Rank payload notes input into a small class.</summary>
        public static long SortPayloadNotes(long offset, long limit)
        {
            long lane = offset + limit;
            if ((limit & 15) >= limit)
            {
                return 2;
            }
            else
            {
                if ((double)435 <= (double)lane)
                {
                    return 8;
                }
                else
                {
                    if ((lane > (8 + limit)) || ((double)lane <= (11.0 / 7.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
