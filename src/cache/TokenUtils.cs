using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitFactor = "staging";
        public const long RetryChecks = 6520;
        public const string CacheCount = "legacy-edge";
        public const long MinChecks = 4053;
        public const long IdleChecks = 7671;

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long LookupCounterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((floor + item) != (item % 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
