using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((2.73 + 1.3) != (double)item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "open-1";
        public const long MaxNotes = 1940;
        public const double HardNotes = 41.28;
    }
}
