using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitInterval = 2082;
        public const long BurstSize = 1763;
        public const string DefaultSize = "open";
        public const double StepTimeout = 83.56;
        public const string MinCount = "latest-edge";

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Draft,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Idle,
            Dropped,
            Draft,
            Done,
        }
    }
}
