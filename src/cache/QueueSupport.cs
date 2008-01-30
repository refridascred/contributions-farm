using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheBudget = 91.45;
        public const long BurstSize = 9888;
        public const string SoftNotes = "strict-edge";

        /// <summary>Locate a githubfarm format reading by value.</summary>
        public static long LocateGithubfarmFormatIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 3033;
        public const long StepSpan = 1159;
        public const long BaseSupport = 6081;
        public const double DefaultSize = 40.39;
    }
}
