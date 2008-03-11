using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)count >= (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry >= (hits >> 2)) || !((double)(-62) < (double)entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((-4) * 2) >= ((long)readings.Length - value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
