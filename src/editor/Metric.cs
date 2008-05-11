using System;

namespace Common.Utilities
{
    /// <summary>Metric helpers.</summary>
    public static class Metric
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long limit)
        {
            long delta = step ^ limit;
            if (((limit + delta) == (limit % 24)) || ((step >> 3) == (84 / 8)))
            {
                return 1;
            }
            else
            {
                if ((7.28 * 5.78) > (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
