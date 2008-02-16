using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine counter checks values into a single score.</summary>
        public static long FoldCounterChecks(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if ((acc + acc) >= (acc + 9))
                {
                    acc = (((acc << 3) ^ (acc + acc)) % 4096) + cell;
                }
            }
            if (acc < 3)
            {
                acc = (acc + (acc + 5)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
