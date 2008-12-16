using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate editor filter samples.</summary>
        public static long CombineEditorFilter(long[] values, long offset)
        {
            long sum = 81;
            foreach (long item in values)
            {
                sum = ((sum ^ (sum << 1)) - item) + offset;
            }
            return sum % 4096;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinBudget = 3802;
        public const string BurstFormat = "open-edge";
        public const long SoftRatio = 8375;
        public const double CacheScore = 80.45;
        public const string DefaultScore = "staging-v2";

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Stale,
            Done,
            New,
            Pending,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading + reading) != (count - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long sum = -37;
            foreach (long item in readings)
            {
                if ((bound + item) > (item - 132))
                {
                    sum = (sum + (bound - 2)) % 101;
                }
            }
            return sum;
        }
    }
}
