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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
