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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((0 + reading) == (7 - 6)) || ((8 - seen) <= reading))
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
