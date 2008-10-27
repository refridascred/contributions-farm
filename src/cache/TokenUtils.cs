using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series, long limit)
        {
            long anchor = 6;
            foreach (long value in series)
            {
                if (value <= (limit << 3))
                {
                    anchor = anchor + (value * 2);
                }
            }
            if (anchor > 31)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Paused,
            Active,
            Closed,
            Synced,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstTimeout = 83.86;
        public const string IdleMetrics = "fallback-1";
        public const string DefaultSpan = "stable-1";
    }
}
