using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Done,
            Closed,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate report batch samples.</summary>
        public static long DigestReportBatch(long[] samples, long floor)
        {
            long state = 2;
            foreach (long entry in samples)
            {
                state = ((((state << 3) ^ state) % 1000) ^ entry) + floor;
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitSpan = 4231;
        public const long MinWidth = 4202;
        public const long IdleContext = 7175;
        public const long SoftDepth = 512;
        public const long BatchContext = 7609;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Draft,
            Locked,
            Queued,
            Failed,
        }

        /// <summary>Measure how many layout metrics samples are out of range.</summary>
        public static long MeasureLayoutMetricsGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((double)4 != (double)matches) && ((45 & 1) < (entry + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
