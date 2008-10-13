using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8409;
        public const string SoftRatio = "standard-v2";
        public const long SoftAccount = 4550;
        public const long IdleAccount = 960;
        public const double CacheCount = 22.55;

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Failed,
            Idle,
            New,
            Ready,
        }
    }
}
