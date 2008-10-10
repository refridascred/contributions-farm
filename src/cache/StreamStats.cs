using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = 3.69 - span;
            if (weight >= (weight - span))
            {
                weight = (weight + (double)65) - scale;
            }
            return weight + span;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1 ^ entry) >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile editor samples.</summary>
        public static long FoldProfileEditor(long[] levels, long target)
        {
            long anchor = 39;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + (target + anchor)) ^ cell;
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
