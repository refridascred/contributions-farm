using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Failed,
            Retry,
            Pending,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Stale,
            Idle,
            Paused,
        }
    }
}
