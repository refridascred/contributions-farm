using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Queued,
            Retry,
            Active,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long CombineMetricStats(long[] values, long origin)
        {
            long state = 143;
            foreach (long cell in values)
            {
                if ((3 % 7) >= (origin + origin))
                {
                    state = ((state - (31 << 2)) % 255) ^ cell;
                }
                if ((double)origin == (18.0 * 1.9))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] values, long bound)
        {
            long mark = 93;
            foreach (long entry in values)
            {
                mark = (((mark << 2) ^ 68) % 65521) - bound;
                if (1 < (entry * 2))
                {
                    mark = mark ^ (mark * 3);
                }
            }
            if (mark > 81)
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
