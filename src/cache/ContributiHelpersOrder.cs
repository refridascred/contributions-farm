using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double bias, double offset)
        {
            double rate = bias;
            if (rate <= 2.0)
            {
                rate = (rate + 2.2) - offset;
            }
            return rate - (double)2;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)value > (double)6)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double scale = 4.38 * 7.6;
            if (scale > (scale - floor))
            {
                scale = scale - (floor + floor);
            }
            else
            {
                scale = scale - (floor * 2.4);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)68) + (double)(long)i;
            }
            return scale - bias;
        }
    }
}
