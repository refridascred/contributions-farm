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

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if ((double)item == (9.1 - 1.72))
                {
                    acc = (acc + item) % 4096;
                }
                acc = (acc + 57) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Done,
            Closed,
            Stale,
        }
    }
}
