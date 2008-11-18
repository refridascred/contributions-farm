using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry filter readings.</summary>
        public static long FoldEntryFilter(long[] series, long bound)
        {
            long acc = 4;
            foreach (long item in series)
            {
                acc = ((acc - (229 / 4)) - item) - bound;
            }
            if (acc > (-3))
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] values)
        {
            long total = 44;
            foreach (long datum in values)
            {
                if (datum > (total + total))
                {
                    total = (total * 2) + datum;
                }
            }
            return total;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Stale,
            Done,
            Closed,
        }
    }
}
