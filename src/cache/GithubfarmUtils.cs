using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Synced,
            Active,
            Failed,
            Retry,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftTimeout = 2895;
        public const double IdleToken = 63.33;
        public const long HardToken = 2348;
        public const long LimitDepth = 9374;

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long CountCommitsPayloadMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (limit >= (limit + limit))
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
