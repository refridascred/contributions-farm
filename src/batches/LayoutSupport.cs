using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 5072;
        public const long CacheBudget = 7683;
        public const long LimitMetric = 1230;
        public const string StepMetric = "legacy-1";

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 15) <= (floor * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally * 5) != (tally - tally)))
                {
                    tally = ((tally + 1) ^ datum) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6837;
        public const long LimitTimeout = 8653;
        public const long MaxCounter = 2438;
        public const string LimitBudget = "fallback-v2";
        public const string SoftBudget = "open-1";

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset & 3) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
