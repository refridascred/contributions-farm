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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading + reading) > reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
