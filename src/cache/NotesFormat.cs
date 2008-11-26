using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public string Region { get; set; } = "";
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next graph account value from a seed.</summary>
        public static long SeriesGraphAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + 584) % 4096;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((5.5 / 6.0) < (double)hits)
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
