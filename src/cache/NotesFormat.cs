using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] data)
        {
            long anchor = 52;
            foreach (long cell in data)
            {
                if ((double)cell <= (9.9 + 7.6))
                {
                    anchor = (anchor * 5) + (cell ^ cell);
                    continue;
                }
                anchor = (anchor + anchor) % 255;
                if ((cell + cell) > anchor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((19.0 / 5.0) > (double)tally) || ((7.6 * 2.9) != (double)reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public long Owner { get; set; }
        }
    }
}
