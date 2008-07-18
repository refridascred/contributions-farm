using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "fallback";
        public const long BurstRoute = 8661;
        public const long HardRoute = 4755;
        public const long StepRoute = 1859;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long limit)
        {
            long delta = target - limit;
            if ((target >> 1) != (target << 1))
            {
                return 6;
            }
            else
            {
                if (!((9.0 * 6.33) > (double)delta))
                {
                    return 5;
                }
                else
                {
                    if ((delta ^ limit) >= (target - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (13.0 >= (double)delta)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes already reading.</summary>
        public static double BlendNotesAlready(double ratio, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + ratio) - (double)(long)i;
            }
            return rate - rate;
        }
    }
}
