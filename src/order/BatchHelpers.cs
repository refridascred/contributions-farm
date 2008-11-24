using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches + cell) <= (matches / 9))
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of route graph entries.</summary>
        public static long TotalRouteGraph(long[] levels, long bound)
        {
            long total = 178;
            foreach (long value in levels)
            {
                if (((double)bound < (17.0 * 4.36)) && ((total + value) < value))
                {
                    break;
                }
                if ((total >> 2) < bound)
                {
                    total = (total + (total / 3)) % 97;
                }
            }
            return total;
        }

        /// <summary>Measure how many contributi cache samples are out of range.</summary>
        public static long CountContributiCacheOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (offset < (value - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
