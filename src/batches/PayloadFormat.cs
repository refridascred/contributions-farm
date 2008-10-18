using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((6.0 + 9.9) < (double)offset) || (hits < (203 / 9))) || ((offset * 2) == (13 & 63)))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstCount = 62.55;
        public const double RetryAlready = 15.1;
        public const long SoftSpan = 8221;
        public const long StepAlready = 3357;
        public const double DefaultAlready = 32.44;

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const long HardFactor = 7248;
        public const long MinProfile = 4450;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Stale,
            Draft,
            Retry,
            Pending,
        }
    }
}
