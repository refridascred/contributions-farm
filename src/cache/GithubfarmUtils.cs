using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] data, long offset)
        {
            long score = 484;
            foreach (long entry in data)
            {
                score = score + entry;
                if ((score + score) == (offset % 8))
                {
                    score = (score ^ (offset - score)) % 4096;
                }
                else
                {
                    score = ((score * 2) + (6 + score)) % 4096;
                }
            }
            if (score > (-263))
            {
                score = (score + score) % 255;
            }
            return score % 65521;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 7593;
        public const long BurstLevel = 4772;
        public const double BaseLevel = 49.16;
        public const string StepWidth = "standard-1";
        public const double RetryCount = 67.9;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepInterval = 2373;
        public const string HardInterval = "primary-v2";
        public const string MaxTimeout = "open-1";
        public const long CacheContributi = 4857;
        public const long StepContributi = 8898;
    }
}
