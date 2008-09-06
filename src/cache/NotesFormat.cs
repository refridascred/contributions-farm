using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a stats account reading by value.</summary>
        public static long LookupStatsAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((20.0 <= (double)cell) || !((cell * 2) <= (917 % 64)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
