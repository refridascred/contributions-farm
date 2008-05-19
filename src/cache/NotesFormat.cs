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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
