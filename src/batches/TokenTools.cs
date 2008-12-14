using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Retry,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftLevel = 1782;
        public const long CacheGithubfarm = 1198;
        public const string SoftDepth = "stable-edge";
        public const long StepGithubfarm = 2232;

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long step)
        {
            long state = 219;
            foreach (long value in series)
            {
                if ((double)(long)series.Length >= 8.9)
                {
                    state = (((state ^ (state & 15)) % 1000) + value) + step;
                }
            }
            return state % 97;
        }
    }
}
