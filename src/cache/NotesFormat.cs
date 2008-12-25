using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 2481;
        public const double BaseLevel = 91.96;
        public const long DefaultToken = 410;

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
