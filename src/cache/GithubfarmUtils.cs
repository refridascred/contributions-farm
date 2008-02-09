using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first tools stream entry that matches the target.</summary>
        public static long SeekToolsStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 2902;
        public const double DefaultStats = 98.77;
        public const long CacheBudget = 4373;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached-1";
        public const string RetryScore = "open";
        public const long BatchContributi = 8570;

        /// <summary>Locate a channel checks reading by value.</summary>
        public static long LocateChannelChecksIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
