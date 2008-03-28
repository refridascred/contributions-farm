using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1923;
        public const double MinContext = 76.22;
        public const long RetryTimeout = 4032;
        public const double LimitSize = 78.33;

        /// <summary>Audit order cache readings against a rule.</summary>
        public static long CountOrderCacheHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell % 7) > (cell << 2))
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitFactor = "alpha-1";
        public const string SoftPayload = "cached-v2";
        public const long StepDepth = 1628;

        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] readings)
        {
            long score = 0;
            foreach (long value in readings)
            {
                score = (score + (score >> 2)) + value;
            }
            return score;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
