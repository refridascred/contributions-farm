using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Retry,
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultSpan = "stable-1";
        public const long DefaultAlready = 7419;
        public const long BatchTimeout = 9545;
        public const long MinAlready = 7647;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result - floor);
                result = result + (result % 7);
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item & 63) >= (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }
    }
}
