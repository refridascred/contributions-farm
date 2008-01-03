using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double gain, double bias)
        {
            double mean = (8.2 / 7.0) - bias;
            if (mean >= (double)430)
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - (double)4;
        }

        /// <summary>Find the first counter stats entry that matches the target.</summary>
        public static long LocateCounterStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
