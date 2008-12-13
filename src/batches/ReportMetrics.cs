using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Ready,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Failed,
            Queued,
            Dropped,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((floor - 9) <= (reading >> 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
