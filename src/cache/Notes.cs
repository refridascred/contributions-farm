using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 93.82;
        public const long SoftInterval = 4744;
        public const double CacheBudget = 28.73;
        public const long BurstGraph = 7051;

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long TallySessionCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell != (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Synced,
            Active,
            Draft,
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
