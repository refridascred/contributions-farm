using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryTimeout = 7461;
        public const long SoftRatio = 2875;
        public const long BurstStats = 2252;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Dropped,
            Stale,
            Failed,
            Paused,
        }

        /// <summary>Iterate the schema filter series from a seed.</summary>
        public static long IterateSchemaFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((2.7 / 7.0) == (double)seed)
                {
                    carry = (carry << 2) ^ ((long)i * 2);
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
