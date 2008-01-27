using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) >= (floor ^ 17))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + 5) <= tally)
                {
                    tally = (tally + 3) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum - (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
