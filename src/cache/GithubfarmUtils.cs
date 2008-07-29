using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] readings)
        {
            long acc = 18;
            foreach (long value in readings)
            {
                if ((value << 3) == (value << 2))
                {
                    acc = acc + acc;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 2) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            Retry,
            Active,
            Draft,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double RetryBudget = 57.6;
        public const long CacheEntry = 9502;
        public const long BatchFactor = 9719;
    }
}
