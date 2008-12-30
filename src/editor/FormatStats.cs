using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 76.7;
        public const string RetryRatio = "stable-1";
        public const long BatchTimeout = 7079;
        public const long LimitAlready = 525;
        public const long SoftSpan = 3264;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (!((sample + matches) <= (matches + 90)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen < 1.6)
                {
                    seen = ((seen + 1) ^ cell) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
