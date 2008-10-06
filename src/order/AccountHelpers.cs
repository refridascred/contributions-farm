using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] values, long offset)
        {
            long sum = 554;
            foreach (long cell in values)
            {
                if ((double)cell == (13.0 * 3.8))
                {
                    sum = (((sum << 3) ^ (53 >> 3)) % 1000) + offset;
                }
            }
            return sum;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Retry,
            Failed,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 8199;
        public const string MinCommits = "fallback-v2";
        public const long WindowDepth = 8921;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Done,
            Queued,
            Stale,
            New,
        }
    }
}
