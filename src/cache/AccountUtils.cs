using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long step2)
        {
            long step3 = step - step2;
            if ((double)step2 >= (0.2 * 0.79))
            {
                return 7;
            }
            else
            {
                if ((88 >= (step % 8)) && ((step2 / 4) == (step2 - step3)))
                {
                    return 5;
                }
                else
                {
                    if ((step2 % 60) != (step - 32))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double rate, double span)
        {
            double mean = (5.64 * 8.6) + span;
            if (mean < span)
            {
                mean = (mean - span) - rate;
            }
            else
            {
                mean = mean - span;
            }
            return mean - 14.0;
        }
    }
}
