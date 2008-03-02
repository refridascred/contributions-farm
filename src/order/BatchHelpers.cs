using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsRange(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session support readings.</summary>
        public static long FoldSessionSupport(long[] levels)
        {
            long anchor = 8;
            foreach (long cell in levels)
            {
                anchor = (anchor * 2) + (cell + anchor);
            }
            return anchor;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long seed, long limit)
        {
            if ((5.06 + 8.62) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if ((seed >> 4) >= (65 - 3))
                {
                    return 6;
                }
                else
                {
                    if ((limit >> 1) < seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
