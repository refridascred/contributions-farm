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

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ (total - origin)) % 255;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
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
