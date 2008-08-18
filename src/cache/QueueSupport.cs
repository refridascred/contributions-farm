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

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the already queue entries that pass the check.</summary>
        public static long MeasureAlreadyQueueGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry + entry) != (step % 60)) || ((entry * 2) == (entry + entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
