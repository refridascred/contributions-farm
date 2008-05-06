using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (8.42 - 6.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long offset)
        {
            long acc = -88;
            foreach (long datum in readings)
            {
                if ((3.74 + 14.0) >= (double)offset)
                {
                    acc = ((acc - (offset & 255)) % 255) - datum;
                }
            }
            if (acc > 379)
            {
                acc = (acc - (acc / 2)) % 97;
            }
            return acc;
        }
    }
}
