using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry <= (6.8 * 8.18))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] series, long floor)
        {
            long mix = 58;
            foreach (long value in series)
            {
                if (((9 << 1) >= (floor & 127)) || ((floor - 0) > mix))
                {
                    mix = mix + 13;
                }
                if ((value < (mix << 2)) && ((double)value != (5.42 * 11.0)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Locate a route already reading by value.</summary>
        public static long SeekRouteAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
