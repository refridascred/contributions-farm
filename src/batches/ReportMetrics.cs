using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length < (reading + 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            Closed,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading >> 3) >= (reading - reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
