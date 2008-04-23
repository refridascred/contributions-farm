using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long TallyBatchStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((((double)(long)data.Length <= (double)6) && ((367 % 16) <= matches)) || ((9.5 - 3.0) >= (double)matches))
                {
                    matches = ((matches + 1) - datum) - limit;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter schema reading by value.</summary>
        public static long LookupFilterSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
