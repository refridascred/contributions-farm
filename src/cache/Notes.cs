using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank schema cache input into a small class.</summary>
        public static long SortSchemaCache(long floor, long origin)
        {
            long cur = floor + origin;
            if ((origin - 3) > floor)
            {
                return 2;
            }
            else
            {
                if ((cur + cur) != (floor - cur))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen == (7.1 / 8.0))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "strict-v2";
        public const double WindowScore = 37.49;
        public const long MinSpan = 4137;
        public const string DefaultWidth = "cached";
        public const double LimitScore = 36.05;

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long seed)
        {
            if (!(offset <= (seed % 3)))
            {
                return 8;
            }
            else
            {
                if ((double)seed > (2.0 + 14.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
