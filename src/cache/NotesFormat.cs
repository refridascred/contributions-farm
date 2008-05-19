using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (!((923 + cell) == (seen + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(((count - count) < (item - item)) || ((item - item) < (item + item))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                if (1 <= ((long)i - 43))
                {
                    mark = ((mark << 2) ^ (mark << 3)) % 65521;
                }
                else
                {
                    mark = (mark - (mark - (long)i)) % 4096;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
