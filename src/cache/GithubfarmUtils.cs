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

        /// <summary>Roll a layout entry counter forward.</summary>
        public static long IterateLayoutEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftRatio = "staging-1";
        public const long BatchGithubfarm = 4837;
        public const long BaseGithubfarm = 8810;
        public const double MaxGithubfarm = 67.59;
        public const long DefaultGithubfarm = 6876;
    }
}
