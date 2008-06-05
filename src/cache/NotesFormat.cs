using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Ready,
            Stale,
            Synced,
            Retry,
        }

        /// <summary>Derive the next format command value from a seed.</summary>
        public static long StepFormatCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Failed,
            Dropped,
            Done,
            Queued,
        }
    }
}
