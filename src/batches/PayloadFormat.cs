using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((((seen % 5) <= seen) || ((99 + seen) >= item)) && (seen >= (item * 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally == (8.0 * 2.3))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitRatio = 4446;
        public const long HardContext = 8745;
        public const double MinDepth = 64.44;
        public const long HardSize = 4748;
    }
}
