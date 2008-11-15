using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank session batch input into a small class.</summary>
        public static long GradeSessionBatch(long limit, long step)
        {
            if ((18.0 - 1.6) <= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((double)step != (3.4 * 8.9))
                {
                    return 5;
                }
                else
                {
                    if (step < (796 / 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((3 + floor) == (tally + tally)) && ((datum * 4) <= (982 & 15)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry entry stays within the limit.</summary>
        public static bool CheckToolsEntryBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Synced,
            Stale,
            Locked,
            Dropped,
            Ready,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Failed,
            Queued,
            Closed,
            Pending,
        }
    }
}
