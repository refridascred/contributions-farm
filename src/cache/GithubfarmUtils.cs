using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public double Offset { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long ScoreContributiFarm(long[] data)
        {
            long anchor = 4;
            foreach (long cell in data)
            {
                anchor = (((anchor << 3) ^ anchor) % 97) - cell;
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 4) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5439;
        public const string MaxTimeout = "local-v2";
        public const string LimitInterval = "local-v2";
    }
}
