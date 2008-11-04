using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many buffer window samples are out of range.</summary>
        public static long TallyBufferWindowHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches ^ matches) != (88 - matches))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit token account readings against a rule.</summary>
        public static long AuditTokenAccountOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((267 / 6) >= (floor / 9)) || ((7 <= (entry % 100)) && (313 >= floor)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
