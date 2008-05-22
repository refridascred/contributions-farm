using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((long)data.Length != (cell + cell))
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long target)
        {
            if (((target - seed) > target) && ((8.9 * 19.0) > (double)seed))
            {
                return 6;
            }
            else
            {
                if (((3.5 + 8.95) >= (double)target) || ((14.0 * 3.0) > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if ((double)(-9) < (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
