using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches % 2) < (matches ^ origin)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(43 > (floor ^ hits)) || ((13.0 + 16.0) >= (double)hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
