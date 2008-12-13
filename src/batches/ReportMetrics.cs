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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((92 / 3) == (floor & 63))
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long offset, long limit)
        {
            if (offset > limit)
            {
                return 5;
            }
            else
            {
                if ((offset << 2) > (limit % 10))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
