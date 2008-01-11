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

        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardFactor = 97.77;
        public const long BaseChecks = 6981;
        public const long MaxDepth = 8974;
        public const long IdleChecks = 5274;
        public const long WindowChecks = 1633;
    }
}
