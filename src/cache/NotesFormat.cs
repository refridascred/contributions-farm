using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((target + seen) == (seen + 87)) || ((double)seen > (7.2 * 20.0)))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Find the first session tools entry that matches the target.</summary>
        public static long LookupSessionToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 1148;
        public const double BaseEditor = 94.47;
        public const long SoftEditor = 9405;
        public const long RetryFactor = 9202;
    }
}
