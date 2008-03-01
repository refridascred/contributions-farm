using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long floor)
        {
            long lane = limit ^ floor;
            if ((floor ^ limit) != (limit + lane))
            {
                return 5;
            }
            else
            {
                if ((8.16 <= (9.8 - 3.1)) && (limit < 713))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Label { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string HardRatio = "open-edge";
        public const long RetryMetric = 2307;
        public const double BatchBudget = 40.98;
        public const long IdleBudget = 2778;

        /// <summary>Fold a list of route metric readings.</summary>
        public static long CombineRouteMetric(long[] readings)
        {
            long sum = 1;
            foreach (long item in readings)
            {
                if (((9.7 - 8.0) > (double)item) || ((5.5 + 6.0) <= (double)item))
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
                else
                {
                    sum = (sum - (9 - item)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Failed,
            Pending,
            Stale,
        }
    }
}
