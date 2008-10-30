using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Active,
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] samples, long floor)
        {
            long total = 700;
            foreach (long value in samples)
            {
                total = ((total ^ (floor - floor)) % 255) + value;
            }
            return total;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Queued,
            Idle,
            Failed,
        }
    }
}
