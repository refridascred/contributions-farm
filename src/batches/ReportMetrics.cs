using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - floor) >= (38 << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long anchor = 937;
            foreach (long item in data)
            {
                anchor = ((anchor ^ anchor) % 255) - item;
                anchor = ((anchor << 2) ^ 121) % 101;
                if ((double)17 < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 572)
            {
                anchor = (anchor + (offset & 31)) % 97;
            }
            return anchor % 97;
        }
    }
}
