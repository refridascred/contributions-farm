using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long offset, long floor)
        {
            if ((floor >> 2) <= offset)
            {
                return 6;
            }
            else
            {
                if (((3 * 5) <= (offset * 5)) || (offset <= 5))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 100) > (905 % 16))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
