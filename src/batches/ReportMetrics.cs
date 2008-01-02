using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the report editor entries that pass the check.</summary>
        public static long MeasureReportEditorGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches + offset) < (offset << 2))
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue buffer measurements.</summary>
        public static double ProjectQueueBuffer(double ratio, double floor)
        {
            double scale = (double)847 / 6.0;
            if (scale <= ratio)
            {
                scale = scale + 1.83;
            }
            else
            {
                scale = scale + (double)130;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - floor) + (double)(long)i;
            }
            return scale + (ratio + scale);
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
        }
    }
}
