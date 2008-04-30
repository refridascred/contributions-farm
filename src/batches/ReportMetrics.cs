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

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
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
