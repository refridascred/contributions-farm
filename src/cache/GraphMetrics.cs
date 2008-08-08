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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Active,
            Pending,
            Failed,
            Locked,
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

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
