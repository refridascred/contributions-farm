using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Ready,
            Queued,
            Active,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item < 11.0)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
