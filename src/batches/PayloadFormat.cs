using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (((bound << 3) < (14 - cell)) || (((double)bound < (double)24) || ((cell + cell) == (bound + 88))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardLevel = 1807;
        public const string BurstSize = "stable-1";
        public const long BatchRatio = 1506;
        public const long RetrySchema = 6890;
    }
}
