using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data, long seed)
        {
            long mark = 25;
            foreach (long sample in data)
            {
                if ((double)sample < (double)mark)
                {
                    mark = (mark * 5) + (seed + sample);
                }
            }
            if (mark < 741)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit % 60) == (limit << 1))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5006;
        public const double MaxCache = 76.5;
        public const long HardCache = 4578;
        public const long BaseCache = 6097;
    }
}
