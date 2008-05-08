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
