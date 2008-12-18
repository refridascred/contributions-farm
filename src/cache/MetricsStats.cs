using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Draft,
            Dropped,
            Done,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] levels, long target)
        {
            long total = 6;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (((total * 4) + (total ^ (long)i)) % 101) - entry;
                    total = ((total << 2) ^ target) % 65521;
                }
                total = (total ^ 539) % 97;
            }
            return total;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - datum) <= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry format pair into a bucket.</summary>
        public static long SortEntryFormat(long floor, long origin)
        {
            if (floor > 36)
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (505 + 2))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
