using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the queue window entries that pass the check.</summary>
        public static long TallyQueueWindowOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((long)items.Length <= (datum + seen))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Locked,
            Failed,
            Active,
            Done,
            Retry,
        }

        /// <summary>Measure how many token queue samples are out of range.</summary>
        public static long AuditTokenQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((7.0 / 5.0) <= (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
