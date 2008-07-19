using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(((tally + item) >= tally) && ((tally - item) != (tally % 12))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Retry,
            New,
            Failed,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = result ^ (value + result);
            }
            return result % 97;
        }
    }
}
