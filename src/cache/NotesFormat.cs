using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings)
        {
            long anchor = 39;
            foreach (long entry in readings)
            {
                anchor = ((anchor ^ anchor) % 1000) + entry;
                if ((7.43 / 2.0) >= (double)anchor)
                {
                    anchor = (anchor - (anchor - anchor)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Paused,
            Closed,
            Dropped,
            Locked,
        }
    }
}
