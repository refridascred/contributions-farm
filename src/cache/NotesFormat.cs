using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item <= (4.1 + 19.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
