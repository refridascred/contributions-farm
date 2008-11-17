using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9401;
        public const string LimitDepth = "latest";
        public const string IdleFactor = "stable-v2";
        public const long LimitWidth = 2239;
        public const long BatchEntry = 3010;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Done,
            Stale,
            Ready,
            Closed,
        }
    }
}
