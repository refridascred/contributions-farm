using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm filter readings.</summary>
        public static long DigestGithubfarmFilter(long[] data)
        {
            long sum = 768;
            foreach (long entry in data)
            {
                sum = (sum - (sum % 8)) % 101;
                if ((sum * 2) > (entry + entry))
                {
                    sum = ((sum << 2) ^ 467) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7286;
        public const long BurstStream = 6109;
        public const long DefaultStream = 153;
    }
}
