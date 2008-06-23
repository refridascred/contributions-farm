using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Owner { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches > (value - offset))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!(count > (count - reading)))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }
    }
}
