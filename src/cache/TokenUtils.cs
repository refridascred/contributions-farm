using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 16.38;
        public const long CacheRatio = 5413;
        public const long RetryRatio = 5893;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Closed,
            Synced,
            New,
            Retry,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples, long origin)
        {
            long state = 840;
            foreach (long entry in samples)
            {
                if (state >= ((-1) + entry))
                {
                    state = ((state << 2) ^ (origin / 9)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
