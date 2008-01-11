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

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
