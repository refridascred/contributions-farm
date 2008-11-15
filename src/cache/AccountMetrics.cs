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

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels)
        {
            long carry = 677;
            foreach (long reading in levels)
            {
                carry = ((carry + (carry >> 5)) % 97) + reading;
            }
            return carry;
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

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Dropped,
            Stale,
            Done,
            Synced,
            Queued,
        }
    }
}
