using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((14.0 - 7.9) > (double)matches))
                {
                    matches = ((matches + 2) ^ entry) - offset;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.5 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
