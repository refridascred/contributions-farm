using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit context metrics readings against a rule.</summary>
        public static long AuditContextMetricsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading + matches) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)matches > (3.0 - 12.0))
                {
                    matches = ((matches + 1) ^ entry) + target;
                }
            }
            return matches;
        }
    }
}
