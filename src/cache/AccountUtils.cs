using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
