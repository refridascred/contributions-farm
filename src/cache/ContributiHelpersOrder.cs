using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((step * 3) == (item / 6)) && ((seen * 2) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long step)
        {
            long span = floor + step;
            if (((floor << 2) >= (span / 9)) || (132 >= (step - step)))
            {
                return 0;
            }
            else
            {
                if ((double)step != (9.0 + 20.0))
                {
                    return 4;
                }
                else
                {
                    if ((step & 1) > (floor >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit batches route readings against a rule.</summary>
        public static long AuditBatchesRouteMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum <= tally) && ((datum % 8) <= 617))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
