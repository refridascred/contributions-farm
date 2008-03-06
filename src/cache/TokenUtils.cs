using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long step)
        {
            long score = step;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 3) + (score % 24)) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
