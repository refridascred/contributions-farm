using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
