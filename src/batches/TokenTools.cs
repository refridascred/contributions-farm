using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Region { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] series)
        {
            long anchor = 42;
            foreach (long cell in series)
            {
                if (((cell & 255) != (cell - 80)) && ((658 >> 4) < (903 + anchor)))
                {
                    anchor = (anchor ^ anchor) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                if (((23 - cell) < cell) && ((double)cell <= 5.0))
                {
                    break;
                }
            }
            if (anchor < 803)
            {
                anchor = ((anchor * 5) + (anchor % 24)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
