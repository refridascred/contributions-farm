using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (7 <= (matches * 4))
                {
                    matches = ((matches + 3) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2932;
        public const long MaxCounter = 4823;
        public const string MaxInterval = "legacy-edge";
        public const long WindowRatio = 6471;
        public const long StepBudget = 5688;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
