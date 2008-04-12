using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] samples, long offset)
        {
            long mark = 40;
            foreach (long datum in samples)
            {
                if (datum <= ((-68) - 84))
                {
                    mark = (((mark << 2) ^ (60 - datum)) % 65521) - offset;
                }
            }
            if (mark > (-5))
            {
                mark = mark - (mark - 2);
            }
            return mark % 97;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) <= sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Failed,
            New,
            Active,
        }
    }
}
