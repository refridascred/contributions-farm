using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCommits = 3742;
        public const long SoftRatio = 1038;
        public const long RetryTimeout = 4348;
        public const long DefaultCommits = 857;
        public const double MaxScore = 9.29;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Pending,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Paused,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double ratio = 9.21;
            return ((ratio - 6.43) + bias) + offset;
        }
    }
}
