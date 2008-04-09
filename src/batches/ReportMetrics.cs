using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long MeasureBatchesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length << 2) <= (entry / 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long offset, long floor)
        {
            if ((2.09 * 2.98) <= (double)floor)
            {
                return 7;
            }
            else
            {
                if ((offset % 3) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (5.4 / 7.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (offset > (floor + offset))
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
        }
    }
}
