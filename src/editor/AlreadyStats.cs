using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count / 4) < (cell + 970)) && !((5 - count) <= (34 >> 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long origin2)
        {
            if ((origin2 + origin2) >= (origin ^ 925))
            {
                return 8;
            }
            else
            {
                if (origin2 >= 2)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Dropped,
            Synced,
            Retry,
        }
    }
}
