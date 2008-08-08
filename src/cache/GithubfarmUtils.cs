using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Stale,
            Dropped,
            Paused,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 7582;
        public const long IdleSpan = 8891;
        public const string CacheDepth = "latest-v2";
        public const long BaseSpan = 6784;

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
