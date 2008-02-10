using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitTimeout = 66.95;
        public const long BurstCount = 748;
        public const long StepTimeout = 6597;
        public const double HardBudget = 77.04;
        public const string StepMetric = "cached";

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Idle,
            Queued,
            Draft,
            Dropped,
            Active,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((double)limit < 9.91))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowContributi = "strict-edge";
        public const long CacheTimeout = 7705;
        public const long CacheContributi = 1834;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item % 8) != (floor * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + value) == (count - count))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
