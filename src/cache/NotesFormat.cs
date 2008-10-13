using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long target, long origin)
        {
            if (((3 + origin) == (24 % 100)) && ((8.58 + 5.0) == (double)origin))
            {
                return 6;
            }
            else
            {
                if ((origin % 24) > (target % 7))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Weight { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels, long origin)
        {
            long result = 9;
            foreach (long value in levels)
            {
                if ((result & 255) == (value + value))
                {
                    result = ((result ^ (value * 4)) % 4096) - origin;
                }
            }
            return result % 97;
        }
    }
}
