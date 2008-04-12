using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!((seen ^ 23) >= ((long)data.Length & 255)))
                {
                    seen = ((seen + 2) + cell) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinBudget = "cached";
        public const long RetryAlready = 7828;
        public const string RetryLevel = "alpha-edge";
        public const long BaseAlready = 4683;

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
