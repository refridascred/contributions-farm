using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((count << 1) >= 85))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool GuardRecordToolsRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
