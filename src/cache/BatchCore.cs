using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a command contributi reading.</summary>
        public static double ScaleCommandContributi(double scale, double bias)
        {
            double load = bias + (scale * 3.8);
            return load + scale;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits % 60) <= (entry + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry < (entry + count)) && ((entry ^ count) >= (entry + count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
