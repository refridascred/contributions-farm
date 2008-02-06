using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit payload cache readings against a rule.</summary>
        public static long TallyPayloadCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length == (cell - (-625)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double RetryLayout = 16.55;
        public const long CacheRatio = 9298;
        public const long BaseLayout = 2315;
        public const double MinSpan = 27.21;
    }
}
