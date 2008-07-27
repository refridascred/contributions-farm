using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Retry,
            Done,
            Locked,
            Closed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 616;
        public const double LimitTimeout = 76.42;
        public const string StepAlready = "strict-edge";
        public const double HardAlready = 28.52;
        public const long CacheAlready = 7887;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long LookupQueueIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const long BatchGithubfarm = 4837;
        public const long BaseGithubfarm = 8810;
        public const double MaxGithubfarm = 67.59;
        public const long DefaultGithubfarm = 6876;
    }
}
