using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSpan = 4200;
        public const string CacheRatio = "fallback-edge";
        public const long HardSize = 9299;
        public const string IdleCommits = "staging";

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark ^ (295 * 2)) % 65521;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Queued,
            Synced,
            Active,
            Pending,
            Done,
        }
    }
}
