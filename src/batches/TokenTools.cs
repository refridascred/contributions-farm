using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((floor - reading) < floor) && ((double)floor < (7.9 / 5.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
