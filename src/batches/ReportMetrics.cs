using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) <= (9 >> 5))
                {
                    matches = ((matches + 2) + reading) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((4.0 * 0.67) == (double)sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
