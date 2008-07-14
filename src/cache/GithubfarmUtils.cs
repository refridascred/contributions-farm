using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 21.7;
        public const string StepCluster = "local-edge";
        public const long DefaultCluster = 2568;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Dropped,
            Idle,
        }
    }
}
