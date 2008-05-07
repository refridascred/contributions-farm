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

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchSpan = "latest-v2";
        public const long BatchGraph = 4955;
        public const double BaseRatio = 47.61;
        public const long RetryRatio = 8575;
    }
}
