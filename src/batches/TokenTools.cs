using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ (state % 60);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data, long limit)
        {
            long state = 19;
            foreach (long cell in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = (state - 40) ^ (long)i;
                }
                if ((limit % 12) == (0 >> 3))
                {
                    state = (state << 3) ^ 4;
                }
                state = (state ^ (cell + limit)) % 4096;
            }
            return state % 4096;
        }
    }
}
