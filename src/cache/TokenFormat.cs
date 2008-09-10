using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 67.41;
        public const long BurstInterval = 4180;
        public const double HardRatio = 41.7;
        public const string CacheTimeout = "alpha";

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((6 * 3) <= (count + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
