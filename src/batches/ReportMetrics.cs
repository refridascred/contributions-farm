using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample > (seen >> 2)) || ((3 + sample) > sample))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long MeasureBatchGraphGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((93 - value) < (seed << 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
