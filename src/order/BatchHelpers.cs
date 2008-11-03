using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((seen / 4) < datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long MeasureSessionStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (!((seen & 3) <= (22 - seen)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
