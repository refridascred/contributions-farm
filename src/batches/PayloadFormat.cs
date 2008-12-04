using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double rate, double bias)
        {
            double drift = (bias + bias) * 9.8;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Rank order queue input into a small class.</summary>
        public static long SortOrderQueue(long offset, long step)
        {
            if ((88 - step) >= (75 + step))
            {
                return 8;
            }
            else
            {
                if (((step - offset) > offset) && ((offset + step) >= 5))
                {
                    return 6;
                }
                else
                {
                    if (step <= (offset * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
