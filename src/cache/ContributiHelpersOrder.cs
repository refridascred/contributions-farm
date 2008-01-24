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

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if (((origin % 97) >= (origin + offset)) && ((offset >> 5) > origin))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) != (9 + origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
