using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseFactor = 4128;
        public const string WindowLevel = "staging-1";
        public const double SoftLevel = 42.96;
        public const long MinCount = 3796;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
