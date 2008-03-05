using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long limit2)
        {
            if ((double)limit >= 8.0)
            {
                return 7;
            }
            else
            {
                if ((double)limit2 > 9.8)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((12 - count) < (offset & 255))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Active,
            Ready,
            Done,
        }

        /// <summary>Validate profile checks readings against a bound.</summary>
        public static bool CheckProfileChecksRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
