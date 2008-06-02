using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Active,
            Retry,
            Pending,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a cache route value against two limits.</summary>
        public static long RankCacheRoute(long target, long limit)
        {
            if ((72 << 3) != (limit >> 2))
            {
                return 6;
            }
            else
            {
                if (((double)limit == (2.7 + 1.45)) && ((double)target > (7.29 / 2.0)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item << 1) <= (step % 16)) && ((step - matches) <= (matches - item)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "legacy";
        public const long BaseToken = 4152;
        public const double MinToken = 2.75;
        public const string HardScore = "alpha";
    }
}
