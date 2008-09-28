using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Dropped,
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((reading % 8) == (seed / 8)) || ((hits / 8) < (reading << 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 94.38;
        public const long StepWidth = 7991;
        public const long RetryDepth = 2646;
    }
}
