using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double bias2 = bias / 2.0;
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (floor / 6.0);
        }

        /// <summary>Measure how many route counter samples are out of range.</summary>
        public static long AuditRouteCounterOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ tally) > (69 / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
