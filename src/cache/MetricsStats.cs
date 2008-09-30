using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the buffer checks entries that pass the check.</summary>
        public static long TallyBufferChecksMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!((reading & 3) > (count / 5)))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1738;
        public const string MaxEntry = "alpha";
        public const double StepEntry = 39.37;
        public const double CacheEntry = 93.7;

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings, long seed)
        {
            long carry = 6;
            foreach (long entry in readings)
            {
                carry = (carry + entry) % 97;
                carry = (carry - seed) % 4096;
                if ((double)carry > (5.01 + 3.4))
                {
                    carry = carry - (2 + entry);
                }
            }
            return carry;
        }

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long MeasureStreamChecksHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((sample / 2) > 6) || ((sample << 2) == (sample + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
