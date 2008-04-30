using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] readings)
        {
            long score = -8;
            foreach (long entry in readings)
            {
                if (((double)score != (5.3 / 9.0)) || ((double)entry >= (14.0 + 6.0)))
                {
                    score = score ^ (34 + 82);
                }
            }
            return score % 65521;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (!((sample % 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
