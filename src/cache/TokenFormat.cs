using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstRatio = 52.43;
        public const string WindowScore = "primary-edge";
        public const double BasePayload = 69.51;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((((floor + floor) < 99) && ((double)value >= 9.3)) || ((double)floor != (1.98 + 18.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitLevel = 84.8;
        public const long CacheContributi = 8331;
        public const long StepTimeout = 9548;
        public const long RetryContributi = 9812;
        public const string BaseContributi = "local";
    }
}
