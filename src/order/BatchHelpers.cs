using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series, long seed)
        {
            long mark = 163;
            foreach (long entry in series)
            {
                mark = ((((mark << 2) ^ (mark & 127)) % 101) - entry) - seed;
            }
            return mark;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Stale,
            New,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Stale,
            Locked,
            Queued,
        }
    }
}
