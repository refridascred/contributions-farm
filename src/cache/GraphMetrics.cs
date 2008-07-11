using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((1 + tally) < (datum / 4)) && ((double)tally >= (7.98 / 9.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 78.24;
        public const double BaseCount = 38.38;
        public const long CacheChecks = 6775;
        public const long StepBudget = 3134;
        public const long RetryChecks = 1863;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((datum + datum) <= (datum + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Pending,
            Stale,
            New,
            Idle,
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
