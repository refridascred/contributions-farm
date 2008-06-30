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

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
