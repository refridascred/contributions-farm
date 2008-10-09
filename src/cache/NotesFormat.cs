using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((datum >> 5) > (matches - datum)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue editor entries that pass the check.</summary>
        public static long CountQueueEditorMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((seen * 5) != (datum + datum))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
