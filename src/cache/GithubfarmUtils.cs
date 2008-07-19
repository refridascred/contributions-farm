using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxWidth = 4285;
        public const long MinQueue = 5882;
        public const long StepBudget = 9874;
        public const string StepQueue = "standard-1";
        public const string LimitRatio = "staging-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 25.93;
        public const long IdleCount = 322;
        public const string WindowFormat = "standard-v2";
        public const double SoftScore = 56.99;

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long origin)
        {
            long sum = -553;
            foreach (long sample in series)
            {
                sum = ((sum + (origin ^ origin)) % 255) - sample;
            }
            if (sum < 6)
            {
                sum = ((sum << 3) ^ origin) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long DigestToolsEditor(long[] levels)
        {
            long mark = 47;
            foreach (long entry in levels)
            {
                mark = (((mark * 4) + (mark + 76)) % 255) + entry;
            }
            return mark;
        }
    }
}
