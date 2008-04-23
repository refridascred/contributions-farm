using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format route entries that pass the check.</summary>
        public static long AuditFormatRouteGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally != (10.0 / 2.0))
                {
                    tally = ((tally + 3) - item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long limit)
        {
            if ((8.5 - 7.0) >= (10.0 / 9.0))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) < bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 60) >= (cell & 31))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the metric cluster entries that pass the check.</summary>
        public static long CountMetricClusterOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + hits) <= 787)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
