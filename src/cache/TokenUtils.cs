using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target + 4) >= (cell * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryLevel = 1625;
        public const long MinQueue = 95;
        public const long HardTimeout = 3530;
        public const double MinInterval = 3.24;
        public const long MinScore = 2818;
    }
}
