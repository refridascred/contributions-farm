using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 8747;
        public const long SoftCache = 2817;
        public const double DefaultCache = 46.88;
        public const string WindowCache = "cached";

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long DigestMetricsQueue(long[] items, long bound)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                sum = ((sum - (bound << 1)) % 97) - datum;
            }
            if (sum > 73)
            {
                sum = (sum * 3) + (79 - 9);
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Retry,
            Locked,
            Active,
            Paused,
            Ready,
        }
    }
}
