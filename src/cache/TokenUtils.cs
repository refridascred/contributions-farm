using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit filter batch readings against a rule.</summary>
        public static long AuditFilterBatchGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((778 + item) > (long)items.Length)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((7.75 + 5.13) < (double)floor) || (15.0 > (double)floor))
                {
                    count = (count + 2) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
