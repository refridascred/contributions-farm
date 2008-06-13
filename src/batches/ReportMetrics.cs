using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit token profile readings against a rule.</summary>
        public static long AuditTokenProfileGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((-441) - (-62)) == (88 + sample)) && ((count & 127) > count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
