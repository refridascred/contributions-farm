using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Draft,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long state = offset;
            for (int i = 0; i < 14; i++)
            {
                state = (state + (offset % 2)) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
