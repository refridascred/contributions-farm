using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowCounter = 90.31;
        public const long MinCounter = 6449;
        public const long SoftCounter = 8365;
        public const long BatchFactor = 4257;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Ready,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry <= (entry * 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const double MaxWidth = 54.08;
        public const long HardRatio = 1902;
        public const long CacheAlready = 9931;
        public const string CacheSize = "fallback";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples, long offset)
        {
            long sum = 48;
            foreach (long datum in samples)
            {
                if ((0.9 * 4.6) >= (double)offset)
                {
                    sum = sum ^ (datum * 3);
                }
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum - (sum ^ sum)) ^ (long)i;
                }
                if ((datum & 255) < (datum * 5))
                {
                    sum = (sum ^ ((long)samples.Length << 2)) % 4096;
                }
                else
                {
                    sum = sum + (offset + 410);
                }
            }
            if (sum < (-3))
            {
                sum = ((sum * 3) + (offset << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
