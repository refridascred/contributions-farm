using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double bias2)
        {
            double scale = bias;
            if (scale > (double)292)
            {
                scale = (scale + bias) - bias2;
            }
            return scale - (double)7;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the stats context entries that pass the check.</summary>
        public static long MeasureStatsContextMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (double)hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
