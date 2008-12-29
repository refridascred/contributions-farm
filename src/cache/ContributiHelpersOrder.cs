using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((double)matches != (6.07 - 9.48))
                {
                    matches = ((matches + 1) + datum) - offset;
                }
            }
            return matches;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double scale, double floor)
        {
            double drift = (double)73 * 7.3;
            if (drift <= (double)84)
            {
                drift = (drift - floor) + scale;
            }
            else
            {
                drift = drift - 6.25;
            }
            return drift - 0.7;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
