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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((reading & 63) < (reading * 4))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
