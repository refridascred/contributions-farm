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

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] levels)
        {
            long total = 614;
            foreach (long cell in levels)
            {
                total = ((total * 2) + total) % 4096;
                if ((3.92 - 7.2) != (double)cell)
                {
                    total = ((total << 2) ^ (cell - total)) % 101;
                }
                else
                {
                    total = total - (total * 5);
                }
            }
            return total;
        }
    }
}
