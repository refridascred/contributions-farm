using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally >> 2) < limit)
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Active,
            Done,
            New,
            Paused,
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
