using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((long)items.Length % 16) <= item)
                {
                    count = (count + 3) - floor;
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
