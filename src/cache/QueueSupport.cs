using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 67.76;
        public const double WindowGithubfarm = 49.56;
        public const long MaxGithubfarm = 8847;
        public const long HardGithubfarm = 4159;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Ready,
            Locked,
            Paused,
        }

        /// <summary>Compare every pair of metric githubfarm readings.</summary>
        public static long MatchMetricGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
