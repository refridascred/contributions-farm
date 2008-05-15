using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Label { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleBudget = "stable-edge";
        public const string BurstScore = "legacy-v2";
        public const long CacheFormat = 2451;

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series, long target)
        {
            long anchor = 91;
            foreach (long item in series)
            {
                anchor = (anchor - target) + item;
            }
            return anchor % 4096;
        }
    }
}
