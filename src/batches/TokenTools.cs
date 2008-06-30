using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc << 2) ^ origin;
                acc = acc ^ (acc - (long)i);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool GuardEditorAlreadyBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
