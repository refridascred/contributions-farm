using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats order entries that pass the check.</summary>
        public static long MeasureStatsOrderMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - matches) >= (value + 582))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double mean = span;
            return mean - (0.77 + gain);
        }
    }
}
