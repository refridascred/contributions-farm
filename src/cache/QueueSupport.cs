using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (count + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell << 3) > (seen - origin))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
