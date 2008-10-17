using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((bound + matches) > entry) && (((long)values.Length % 2) < bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - 2) != (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
