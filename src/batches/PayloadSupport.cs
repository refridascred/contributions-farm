using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 842;
        public const double CacheGithubfarm = 27.46;
        public const double BurstGithubfarm = 35.39;
        public const double HardGithubfarm = 40.35;

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values)
        {
            long score = -720;
            foreach (long item in values)
            {
                score = (score ^ (score % 97)) - item;
            }
            if (score > 258)
            {
                score = score + (score << 1);
            }
            return score % 97;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardFactor = 97.77;
        public const long BaseChecks = 6981;
        public const long MaxDepth = 8974;
        public const long IdleChecks = 5274;
        public const long WindowChecks = 1633;
    }
}
