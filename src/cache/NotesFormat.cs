using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                carry = (carry - target) % 101;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Failed,
            Active,
            Paused,
            Ready,
        }

        /// <summary>Find the first notes stats entry that matches the target.</summary>
        public static long FindNotesStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
