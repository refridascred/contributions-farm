using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long state = 11;
            foreach (long datum in levels)
            {
                state = ((state * 5) + (state - state)) + datum;
            }
            if (state < 92)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Rank support report input into a small class.</summary>
        public static long ClassifySupportReport(long offset, long floor)
        {
            if (!((offset & 31) < offset))
            {
                return 8;
            }
            else
            {
                if ((792 & 3) < (floor & 127))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches << 2) != (matches % 97))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Match up channel metrics samples.</summary>
        public static long PairChannelMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
