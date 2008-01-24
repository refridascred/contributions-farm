using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            New,
            Ready,
            Pending,
            Active,
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((13.0 - 0.4) != (double)seen)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4.56 < (12.0 - 2.0)) && (((tally - tally) > ((-6) - 98)) || ((tally >> 2) >= (tally + item))))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }
    }
}
