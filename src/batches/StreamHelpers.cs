using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((bound + bound) != (2 - bound))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 1366;
        public const long DefaultRatio = 7831;
        public const long RetrySize = 2181;
        public const double LimitFactor = 63.66;

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
