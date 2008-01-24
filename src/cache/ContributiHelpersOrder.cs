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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((bound * 5) != ((-89) ^ seed))
            {
                return 0;
            }
            else
            {
                if (((694 ^ bound) <= bound) && ((double)slot < (2.07 + 0.68)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
