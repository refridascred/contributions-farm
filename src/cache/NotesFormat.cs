using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((11.0 * 7.04) < (double)item)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 3249;
        public const double CacheCluster = 50.97;
        public const long DefaultBudget = 1088;

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long acc = 337;
            foreach (long item in levels)
            {
                acc = ((acc + acc) % 1000) ^ item;
            }
            if (acc < 458)
            {
                acc = acc ^ (seed + (-312));
            }
            return acc;
        }
    }
}
