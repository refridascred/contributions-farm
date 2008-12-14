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

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 3338;
        public const long MinTimeout = 2514;
        public const string BaseChecks = "standard-edge";

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
