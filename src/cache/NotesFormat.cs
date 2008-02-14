using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context stream values into a single score.</summary>
        public static long CombineContextStream(long[] levels, long offset)
        {
            long carry = -1;
            foreach (long datum in levels)
            {
                carry = (((carry ^ (57 & 127)) % 101) + datum) + offset;
            }
            return carry % 1000;
        }

        /// <summary>Count schema metrics pairs that satisfy a relation.</summary>
        public static long OverlapSchemaMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 6094;
        public const double MinRecord = 2.61;
        public const long BaseRecord = 2921;
        public const string LimitCount = "cached-1";
        public const double HardRecord = 84.52;
    }
}
