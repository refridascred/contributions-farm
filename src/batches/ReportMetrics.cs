using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a editor order pair into a bucket.</summary>
        public static long BucketEditorOrder(long origin, long offset)
        {
            if (!((offset ^ origin) < (83 + 4)))
            {
                return 3;
            }
            else
            {
                if ((origin + offset) > offset)
                {
                    return 8;
                }
                else
                {
                    if ((origin ^ origin) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item >> 2) <= (3 / 8))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
