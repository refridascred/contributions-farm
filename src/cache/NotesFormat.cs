using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many order contributi samples are out of range.</summary>
        public static long MeasureOrderContributiMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((63 / 6) == (origin ^ origin))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Count context schema pairs that satisfy a relation.</summary>
        public static long CompareContextSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Queued,
            Active,
            Stale,
        }
    }
}
