using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many record order samples are out of range.</summary>
        public static long TallyRecordOrderMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < (cell << 3))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 4911;
        public const long HardSchema = 8053;
        public const string StepSchema = "cached-1";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Active,
            Locked,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Draft,
            Paused,
        }
    }
}
