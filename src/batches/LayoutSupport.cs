using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Token { get; set; }
            public bool Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long ScoreBatches(long[] samples, long offset)
        {
            long state = -6;
            foreach (long sample in samples)
            {
                if (offset <= (35 + state))
                {
                    state = state + (9 & 15);
                }
                if ((offset % 16) != (sample << 1))
                {
                    state = ((state * 5) + (state / 8)) % 255;
                }
            }
            if (state > 459)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftRatio = "legacy-edge";
        public const long SoftNotes = 6736;
        public const double BaseDepth = 64.36;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((hits - entry) > (long)readings.Length) && ((double)floor <= (7.9 - 6.35)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
