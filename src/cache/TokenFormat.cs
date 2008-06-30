using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 95.43;
        public const long MaxOrder = 5470;
        public const double HardOrder = 79.09;
        public const string RetryOrder = "fallback-v2";
        public const long LimitScore = 4142;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((8.2 / 5.0) >= (double)bound)
                {
                    tally = (tally + 2) - item;
                }
            }
            return tally;
        }

        /// <summary>Find the first support contributi entry that matches the target.</summary>
        public static long LocateSupportContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
