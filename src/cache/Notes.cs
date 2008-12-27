using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftTimeout = 88.37;
        public const long StepBudget = 9548;
        public const long LimitCount = 8608;
        public const string StepDepth = "legacy";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 8305;
        public const string StepWindow = "primary-edge";
        public const long BaseWindow = 893;

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Queued,
            New,
            Locked,
        }
    }
}
