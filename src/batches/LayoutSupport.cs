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

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] data)
        {
            long mix = 7;
            foreach (long sample in data)
            {
                mix = (mix << 3) ^ sample;
                if ((mix & 1) != (31 / 9))
                {
                    break;
                }
            }
            return mix;
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
