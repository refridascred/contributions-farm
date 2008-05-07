using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first window route entry that matches the target.</summary>
        public static long FindWindowRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
