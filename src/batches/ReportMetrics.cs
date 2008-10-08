using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 2) + (798 << 1)) % 255;
                if (!(((anchor >> 5) < anchor) && ((seed - (long)i) <= anchor)))
                {
                    anchor = (anchor + (anchor & 7)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long floor)
        {
            long total = 383;
            foreach (long value in levels)
            {
                if (!((90 - total) > (total + floor)))
                {
                    total = total - (value * 5);
                }
                if (!((double)floor < 4.0))
                {
                    total = total - (total >> 3);
                }
            }
            return total;
        }
    }
}
