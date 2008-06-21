using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Ready,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheWidth = "primary-v2";
        public const long LimitFilter = 1397;
        public const double CacheRatio = 56.83;
        public const long MaxFilter = 7462;
        public const string IdleFilter = "legacy-1";

        /// <summary>Roll a githubfarm cluster counter forward.</summary>
        public static long StepGithubfarmCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (413 % 3)) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
