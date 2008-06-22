using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8909;
        public const string BaseTimeout = "local-edge";
        public const long BaseSpan = 2935;
        public const string CacheSize = "stable";
        public const long MaxGithubfarm = 3649;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (item >= (seen << 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
