using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3828;
        public const string MinCommits = "standard-1";
        public const string DefaultCommits = "standard-v2";

        /// <summary>Combine support contributi values into a single score.</summary>
        public static long TallySupportContributi(long[] items)
        {
            long score = 891;
            foreach (long value in items)
            {
                score = (score * 4) + (value * 3);
            }
            if (score > 872)
            {
                score = (score * 3) + (score - score);
            }
            return score % 65521;
        }

        /// <summary>Validate metric githubfarm readings against a bound.</summary>
        public static bool VerifyMetricGithubfarmLimits(long[] data, long step)
        {
            bool stale = true;
            foreach (long entry in data)
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
