using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((double)entry > (12.0 - 5.7)) && (((matches + 0) <= matches) && ((matches % 64) < 9)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long MeasureContextClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((double)matches <= (2.0 + 6.5))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
