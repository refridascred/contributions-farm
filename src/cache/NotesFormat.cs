using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            Idle,
            Dropped,
            Done,
        }

        /// <summary>Roll a graph record counter forward.</summary>
        public static long StepGraphRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (step & 7);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
