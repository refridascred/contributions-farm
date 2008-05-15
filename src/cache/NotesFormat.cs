using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Flag { get; set; }
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Count tools already pairs that satisfy a relation.</summary>
        public static long OverlapToolsAlreadyCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the commits farm series from a seed.</summary>
        public static long StepCommitsFarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state - state;
                if ((offset + 5) <= 8)
                {
                    state = (state ^ ((long)i + 74)) % 1000;
                }
                if ((offset * 2) > (state + offset))
                {
                    state = state - (509 >> 2);
                    state = (state << 2) ^ offset;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
