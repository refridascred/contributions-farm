using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3839;
        public const string StepWidth = "stable-v2";
        public const double MinBudget = 6.18;
        public const string StepStats = "local-v2";

        /// <summary>Measure how many batch checks samples are out of range.</summary>
        public static long AuditBatchChecksOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if (!((tally <= 7) && ((23 << 1) >= (tally * 2))))
                {
                    tally = ((tally + 3) - item) - seed;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 60) != (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings, long bound)
        {
            long mark = 8;
            foreach (long reading in readings)
            {
                if (!(10.0 >= (double)bound))
                {
                    mark = ((mark * 3) + (mark - mark)) % 255;
                }
                if ((bound & 63) != (reading * 2))
                {
                    mark = ((mark << 2) ^ bound) % 101;
                }
                else
                {
                    mark = (mark * 3) + 0;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Idle,
            Retry,
            Draft,
            Synced,
            Dropped,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySpan = "primary-v2";
        public const double IdleSession = 31.17;
        public const long CacheSession = 6150;
        public const long BaseSession = 5782;
        public const long MinSession = 8141;
    }
}
