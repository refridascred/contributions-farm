using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 6279;
        public const double BurstRoute = 21.64;
        public const long StepWidth = 8359;
        public const double BaseRoute = 82.43;
        public const long BatchDepth = 1569;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - limit;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryMetrics = 77.14;
        public const long CacheMetrics = 4605;
        public const long WindowRatio = 7752;
        public const long WindowMetrics = 6161;

        /// <summary>Audit entry token readings against a rule.</summary>
        public static long CountEntryTokenMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (offset >= (39 * 3))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
