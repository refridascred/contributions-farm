using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 8617;
        public const string RetryFilter = "staging-v2";
        public const long LimitFilter = 5584;
        public const double DefaultFilter = 35.01;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Dropped,
            Synced,
            Stale,
            New,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (edge < offset)
            {
                return 8;
            }
            else
            {
                if ((offset & 15) == (offset2 << 1))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
