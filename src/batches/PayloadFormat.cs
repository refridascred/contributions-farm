using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Queued,
            Closed,
            Draft,
            Failed,
            Paused,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Idle,
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen <= (0.41 * 9.83))
                {
                    seen = ((seen + 3) ^ item) + bound;
                }
            }
            return seen;
        }
    }
}
