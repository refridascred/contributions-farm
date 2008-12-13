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

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((35 - bound) < (bound * 2))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }
    }
}
