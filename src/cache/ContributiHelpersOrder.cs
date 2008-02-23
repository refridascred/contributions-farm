using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            New,
            Draft,
            Ready,
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state - (step ^ state);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
