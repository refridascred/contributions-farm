using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every tools session entry stays within the limit.</summary>
        public static bool GuardToolsSessionBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next filter value.</summary>
        public static double SmoothFilter(double scale, double span)
        {
            double rate = scale;
            if (rate > (rate * 9.93))
            {
                rate = rate - (double)(-446);
            }
            else
            {
                rate = rate - (double)(-250);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - span) + (double)(long)i;
            }
            return rate + (double)374;
        }
    }
}
