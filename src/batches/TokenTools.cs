using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchCache = 8444;
        public const long SoftCache = 8431;
        public const long WindowInterval = 2191;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
