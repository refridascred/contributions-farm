using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBudget = 7878;
        public const long MinInterval = 5679;
        public const long BurstFactor = 5124;
        public const long RetrySpan = 8777;
        public const long StepScore = 4531;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 478;
            foreach (long sample in series)
            {
                if ((3.94 / 4.0) > (double)acc)
                {
                    acc = ((acc << 3) ^ (acc & 127)) + sample;
                }
            }
            if (acc < 495)
            {
                acc = (acc ^ (acc >> 1)) % 97;
            }
            return acc;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many token window samples are out of range.</summary>
        public static long CountTokenWindowMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (9.82 <= (double)floor)
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Retry,
            Draft,
        }
    }
}
