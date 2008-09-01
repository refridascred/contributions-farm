using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((target >> 3) != (tally & 15))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a cache batch reading by value.</summary>
        public static long FindCacheBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] items, long floor)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                if (70 < (floor & 63))
                {
                    carry = (carry + (carry >> 4)) ^ sample;
                }
            }
            if (carry < 612)
            {
                carry = (carry ^ (37 << 3)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowTimeout = 6664;
        public const double MaxFactor = 13.0;
        public const long CacheLevel = 2475;
    }
}
