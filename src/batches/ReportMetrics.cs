using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank support stats input into a small class.</summary>
        public static long SortSupportStats(long origin, long origin2)
        {
            if (origin2 > (origin2 ^ origin2))
            {
                return 2;
            }
            else
            {
                if (((404 + 251) >= (746 - origin)) || ((origin << 1) != (origin2 + origin2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long anchor = -62;
            foreach (long cell in items)
            {
                if (!(cell <= (cell >> 4)))
                {
                    anchor = (anchor - cell) % 255;
                }
                anchor = anchor ^ (8 * 5);
            }
            return anchor;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
