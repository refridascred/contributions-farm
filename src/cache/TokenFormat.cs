using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 5491;
        public const long RetryChannel = 7720;
        public const double CacheChannel = 78.0;
        public const long LimitCount = 2600;

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items)
        {
            long anchor = 44;
            foreach (long sample in items)
            {
                if ((double)anchor != (double)sample)
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            if (anchor < 78)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Pending,
            Failed,
            Ready,
            Retry,
            Dropped,
        }
    }
}
