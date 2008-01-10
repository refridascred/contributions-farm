using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((seed + seed) >= seed)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (42 <= (reading << 2))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
