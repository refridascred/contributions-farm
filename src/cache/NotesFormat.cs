using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry / 4) <= ((-7) - limit))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Failed,
            Paused,
            Idle,
        }
    }
}
