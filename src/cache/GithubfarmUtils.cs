using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 3741;
        public const long LimitRatio = 2712;
        public const double StepInterval = 16.48;

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardSize = 6881;
        public const long CacheProfile = 125;
        public const long DefaultProfile = 6588;
        public const long SoftSize = 3158;

        /// <summary>Compare every pair of commits batch readings.</summary>
        public static long CompareCommitsBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            New,
            Failed,
            Ready,
        }
    }
}
