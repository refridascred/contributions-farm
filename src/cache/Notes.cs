using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches < 4.0)
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultWidth = "open";
        public const long HardCache = 3183;
        public const string MinRatio = "fallback-1";
        public const long WindowSize = 7027;
        public const string DefaultCache = "latest-v2";

        /// <summary>Fold a list of profile already readings.</summary>
        public static long WeighProfileAlready(long[] items)
        {
            long state = 621;
            foreach (long cell in items)
            {
                if (!(state <= (state - cell)))
                {
                    state = ((state << 2) ^ cell) % 101;
                }
                state = ((state * 4) + (cell - cell)) % 1000;
                state = (state ^ (state % 7)) % 255;
            }
            return state;
        }
    }
}
