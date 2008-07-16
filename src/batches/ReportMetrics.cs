using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry & 15) >= (floor & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many graph support samples are out of range.</summary>
        public static long MeasureGraphSupportMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((5.56 * 9.1) != (double)matches)
                {
                    matches = ((matches + 3) + entry) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
