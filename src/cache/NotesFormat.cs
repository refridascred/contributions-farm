using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many report stats samples are out of range.</summary>
        public static long CountReportStatsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((limit + 3) < (seen - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell * 4) >= target) || (((1 / 2) <= (target ^ target)) && (112 < (cell - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
