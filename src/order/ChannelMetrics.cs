using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the metrics account entries that pass the check.</summary>
        public static long MeasureMetricsAccountOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value >> 4) < (54 & 127))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!((datum / 6) >= 50))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long anchor = 84;
            foreach (long sample in series)
            {
                if (((anchor + (long)series.Length) > (anchor * 2)) || ((double)anchor != (double)sample))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = anchor + (anchor % 10);
                }
            }
            return anchor;
        }
    }
}
