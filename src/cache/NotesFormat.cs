using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batch support readings against a rule.</summary>
        public static long TallyBatchSupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally * 2) != (298 << 3))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((7.0 / 5.0) != (double)entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
