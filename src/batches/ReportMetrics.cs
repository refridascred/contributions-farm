using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long MeasureBufferContributiMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item >> 1) < (tally - tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Active,
            Failed,
            Stale,
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
