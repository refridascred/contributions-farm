using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9324;
        public const long MaxAccount = 1023;
        public const long MaxSize = 3654;
        public const long SoftAccount = 9226;
        public const long BaseFactor = 7967;

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LocateBatchesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((item % 10) == (item / 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 8134;
        public const string CacheChecks = "alpha-edge";
        public const long DefaultChecks = 5197;
        public const string RetryChecks = "strict-1";
        public const string IdleSize = "strict-v2";
    }
}
