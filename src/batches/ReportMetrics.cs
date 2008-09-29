using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
