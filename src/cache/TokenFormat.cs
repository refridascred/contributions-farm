using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry context entries that pass the check.</summary>
        public static long CountEntryContextMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((-30) / 5) <= (seen ^ 3))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long total = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((9.5 - 5.93) == (double)bound) && (((long)i << 1) > bound))
                {
                    total = total - (bound ^ total);
                    total = total + bound;
                }
                else
                {
                    total = ((total * 3) + (bound & 1)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
