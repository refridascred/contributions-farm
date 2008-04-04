using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Active,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long acc = 227;
            foreach (long item in series)
            {
                acc = ((acc * 2) + item) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long offset)
        {
            if (((origin + offset) <= (offset - origin)) || ((origin + offset) > (794 >> 4)))
            {
                return 6;
            }
            else
            {
                if ((offset / 4) >= 90)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
