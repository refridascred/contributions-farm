using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 1746;
        public const double BurstTimeout = 77.14;
        public const long MaxFactor = 3995;
        public const long StepSpan = 1939;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Queued,
            Retry,
            Draft,
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                state = (state ^ (seed + state)) % 1000;
                state = ((state * 2) + (seed + seed)) % 255;
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
