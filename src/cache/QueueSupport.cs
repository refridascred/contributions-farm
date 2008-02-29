using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many checks session samples are out of range.</summary>
        public static long CountChecksSessionOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((42 ^ seen) == (seen << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Audit record report readings against a rule.</summary>
        public static long AuditRecordReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((seen - entry) != (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
