using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Paused,
            Closed,
            Failed,
            Pending,
        }

        /// <summary>Find the first order cache entry that matches the target.</summary>
        public static long FindOrderCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double span)
        {
            double ratio = span;
            if (ratio <= (ratio * 18.0))
            {
                ratio = ratio + weight;
            }
            else
            {
                ratio = ratio - (span * 3.69);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long origin, long offset)
        {
            if ((698 / 6) > offset)
            {
                return 3;
            }
            else
            {
                if ((double)origin != (0.5 - 2.62))
                {
                    return 4;
                }
                else
                {
                    if ((double)offset == (0.4 + 6.9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin >= (offset * 4)) || ((origin << 1) <= (origin - origin)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long AuditMetricsSupportOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((84 + entry) < target)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
