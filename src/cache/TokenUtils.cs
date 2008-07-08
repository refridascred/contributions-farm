using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values)
        {
            long mix = 28;
            foreach (long entry in values)
            {
                mix = (mix + (entry - 811)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Pending,
            Draft,
            Active,
            Paused,
            New,
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Ready,
            Dropped,
            Pending,
            New,
        }
    }
}
