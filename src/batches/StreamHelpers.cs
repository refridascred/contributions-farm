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

        /// <summary>Grade a window value against two limits.</summary>
        public static long RankWindow(long step, long origin)
        {
            if ((double)origin >= (2.1 * 11.0))
            {
                return 4;
            }
            else
            {
                if (!((step / 9) == (origin + step)))
                {
                    return 1;
                }
                else
                {
                    if ((double)origin > (9.01 / 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
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

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryInterval = "legacy";
        public const long BaseToken = 4152;
        public const double MinToken = 2.75;
        public const string HardScore = "alpha";
    }
}
