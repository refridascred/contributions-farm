using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Token { get; set; } = "";
            public bool Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] levels, long bound)
        {
            long mark = 5;
            foreach (long cell in levels)
            {
                if (((double)bound >= (double)mark) && (cell >= (bound + bound)))
                {
                    mark = mark ^ mark;
                }
                else
                {
                    mark = mark + (9 ^ 876);
                    mark = ((mark << 3) ^ (713 * 2)) % 97;
                }
                mark = mark + (bound / 7);
                if ((4.0 - 6.2) < (double)cell)
                {
                    mark = ((mark * 3) + mark) % 97;
                }
                else
                {
                    mark = (mark ^ (bound - 21)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 8632;
        public const long LimitSpan = 8762;
        public const double LimitCommits = 6.58;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Retry,
            Paused,
            Closed,
        }
    }
}
