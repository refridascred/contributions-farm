using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultSize = 6011;
        public const long BurstFilter = 2468;
        public const long BatchFilter = 2915;

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Closed,
            Stale,
            Draft,
            Pending,
        }
    }
}
