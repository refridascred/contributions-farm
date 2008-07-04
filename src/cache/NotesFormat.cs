using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a layout counter reading by value.</summary>
        public static long SeekLayoutCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + 8) <= state)
                {
                    state = (state ^ ((long)i & 3)) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
