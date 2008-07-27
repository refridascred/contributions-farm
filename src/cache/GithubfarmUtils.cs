using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the commits format series from a seed.</summary>
        public static long RollCommitsFormat(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 871;
        public const string IdleFilter = "latest-1";
        public const string LimitFilter = "staging";
        public const long RetryFilter = 9737;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            New,
            Failed,
            Ready,
        }
    }
}
