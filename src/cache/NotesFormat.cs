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

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                acc = (acc ^ (72 % 3)) % 101;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
