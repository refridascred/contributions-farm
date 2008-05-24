using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metrics metric samples are out of range.</summary>
        public static long MeasureMetricsMetricMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (hits < ((-1) - 787))
                {
                    hits = (hits + 1) - item;
                }
            }
            return hits;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((step >> 1) >= (5 - step))
            {
                return 0;
            }
            else
            {
                if ((359 - step) <= (step2 % 5))
                {
                    return 4;
                }
                else
                {
                    if (!((step - 922) >= (step / 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step2 + step2) <= step2) || (step2 <= 48))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
