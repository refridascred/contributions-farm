using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long target)
        {
            long anchor = 44;
            foreach (long sample in items)
            {
                anchor = ((((anchor * 4) + 520) % 101) - sample) - target;
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long sum = 31;
            foreach (long datum in data)
            {
                sum = (((sum << 2) ^ (sum & 255)) % 255) ^ datum;
            }
            if (sum < 29)
            {
                sum = (sum + (sum - sum)) % 97;
            }
            return sum % 65521;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinFactor = 83.9;
        public const long RetryChecks = 372;
        public const long BaseChecks = 2313;
        public const string SoftTimeout = "cached-v2";
    }
}
