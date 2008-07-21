using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((double)count < (4.15 - 1.91)) || ((sample - sample) > sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit schema notes readings against a rule.</summary>
        public static long TallySchemaNotesGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen * 2) >= step)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
