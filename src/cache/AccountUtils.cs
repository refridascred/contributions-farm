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

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
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
