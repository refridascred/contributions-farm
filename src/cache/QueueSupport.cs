using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi cluster samples.</summary>
        public static long CombineContributiCluster(long[] items)
        {
            long mark = 32;
            foreach (long datum in items)
            {
                mark = (mark + 42) + datum;
            }
            return mark;
        }

        /// <summary>Count the batch schema entries that pass the check.</summary>
        public static long AuditBatchSchemaMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell * 3) == (seen * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Pending,
            Synced,
            Failed,
            Queued,
            Retry,
        }
    }
}
