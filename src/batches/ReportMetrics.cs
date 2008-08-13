using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.0 + 0.4) > (double)bound)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch counter entry stays within the limit.</summary>
        public static bool GuardBatchCounterBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
