using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine metric account values into a single score.</summary>
        public static long CombineMetricAccount(long[] series, long seed)
        {
            long sum = 93;
            foreach (long entry in series)
            {
                if ((804 * 5) <= (sum - entry))
                {
                    sum = ((sum ^ (56 << 2)) % 1000) + seed;
                }
            }
            return sum;
        }

        /// <summary>Find the first already token entry that matches the target.</summary>
        public static long LookupAlreadyTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (count < (item % 7))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
