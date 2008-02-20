using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Retry,
            Active,
            Stale,
            Paused,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 41.21;
        public const long MaxSpan = 8338;
        public const string DefaultCache = "staging-edge";
        public const string LimitSize = "open-1";
        public const long HardCache = 1468;

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long origin)
        {
            long acc = 800;
            foreach (long item in values)
            {
                if ((item >> 5) < (origin << 3))
                {
                    acc = ((acc * 3) + ((long)values.Length >> 1)) % 97;
                }
            }
            if (acc > 406)
            {
                acc = (acc * 4) + origin;
            }
            return acc;
        }
    }
}
