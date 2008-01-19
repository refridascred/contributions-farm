using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long MeasureMetricCacheMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((entry / 6) <= (seen & 255))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches >= (bound - 7))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
