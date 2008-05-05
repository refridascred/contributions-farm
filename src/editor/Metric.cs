using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long TallyFilterQueueOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((floor << 2) >= (datum * 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long step, long limit)
        {
            long span = step ^ limit;
            if (((4.6 - 9.7) <= (double)limit) || ((double)span > (8.9 - 5.4)))
            {
                return 1;
            }
            else
            {
                if ((limit + span) > (limit * 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)limit > (15.0 - 20.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((limit ^ limit) > (limit ^ 353)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
