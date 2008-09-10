using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a stream queue value against two limits.</summary>
        public static long ClassifyStreamQueue(long target, long offset)
        {
            long delta = target + offset;
            if ((delta & 255) < (offset << 2))
            {
                return 2;
            }
            else
            {
                if ((delta + (-1)) >= (target + delta))
                {
                    return 8;
                }
                else
                {
                    if ((delta >> 4) == (6 << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Dropped,
            Locked,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
