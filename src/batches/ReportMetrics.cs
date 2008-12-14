using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric graph samples are out of range.</summary>
        public static long MeasureMetricGraphGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((limit - 3) <= limit)
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
