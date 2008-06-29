using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits > (4 - hits))
                {
                    hits = ((hits + 3) ^ cell) - floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Pending,
            Queued,
            Synced,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardScore = 8709;
        public const double SoftBudget = 98.55;
        public const long MaxChannel = 6981;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((390 % 24) != (tally + cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                if (!((double)mark > (0.8 - 9.33)))
                {
                    mark = mark + (mark >> 3);
                    mark = mark - value;
                }
                if ((double)mark != (double)59)
                {
                    mark = (mark + (value + value)) % 255;
                    continue;
                }
                mark = (mark - (mark << 2)) % 1000;
            }
            return mark;
        }
    }
}
