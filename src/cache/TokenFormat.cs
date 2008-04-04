using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state << 3) ^ (27 + 4)) % 1000;
                state = state - (160 << 1);
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)origin < (0.07 + 2.6))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
