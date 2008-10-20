using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)datum > 4.9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many entry graph samples are out of range.</summary>
        public static long MeasureEntryGraphMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches << 3) < reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
