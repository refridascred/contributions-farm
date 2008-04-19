using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long WeighReportStats(long[] values, long offset)
        {
            long total = 729;
            foreach (long value in values)
            {
                total = (total + (total + offset)) % 101;
                if ((double)value != (7.18 / 4.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 6027;
        public const long LimitAlready = 5643;
        public const long RetryTimeout = 7567;

        /// <summary>Combine token batch values into a single score.</summary>
        public static long TotalTokenBatch(long[] items, long floor)
        {
            long carry = 81;
            foreach (long sample in items)
            {
                carry = (((carry << 2) ^ (carry + carry)) ^ sample) + floor;
            }
            return carry;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            Closed,
            Ready,
            Draft,
        }
    }
}
