using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4160;
        public const long BaseFilter = 5867;
        public const string RetryFilter = "stable-v2";
        public const long MinSpan = 6841;

        /// <summary>Count the command account entries that pass the check.</summary>
        public static long MeasureCommandAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultFactor = 4870;
        public const long DefaultTimeout = 5721;
        public const long MinCount = 9474;
    }
}
