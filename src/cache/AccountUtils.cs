using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string BaseBudget = "legacy-v2";
        public const string SoftInterval = "alpha-1";
        public const long BatchPayload = 3987;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((target % 100) != (value ^ count)) && ((target << 2) <= (value >> 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
