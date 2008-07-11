using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next account metrics value.</summary>
        public static double SmoothAccountMetrics(double gain, double floor)
        {
            double rate = (double)(64 + 23);
            if (rate < gain)
            {
                rate = (rate + (double)79) + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + gain) - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long target, long step)
        {
            if (step > (26 >> 3))
            {
                return 4;
            }
            else
            {
                if (((double)target <= (14.0 - 20.0)) || ((double)target >= (1.0 * 7.51)))
                {
                    return 0;
                }
                else
                {
                    if (((220 & 1) < (target - step)) || ((double)target <= 5.7))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target * 5) > (step % 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
