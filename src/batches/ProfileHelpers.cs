using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next channel cluster value from a seed.</summary>
        public static long SeriesChannelCluster(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - ((long)i >> 3)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Active,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Queued,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 7274;
        public const long IdleContributi = 3899;
        public const long RetryContributi = 7332;
        public const long BurstContributi = 787;
        public const long WindowTimeout = 9380;

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = (state ^ ((long)i >> 1)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }
    }
}
