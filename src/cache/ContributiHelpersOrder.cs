using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report route value.</summary>
        public static double ProjectReportRoute(double rate, double bias)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (rate * 0.5);
            }
            else
            {
                drift = drift + (drift - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - 6.31;
        }

        /// <summary>Project the next token batch value.</summary>
        public static double ProjectTokenBatch(double scale, double floor)
        {
            double scale2 = 6.4 * 11.0;
            if (scale2 >= (double)8)
            {
                scale2 = (scale2 + (double)5) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 - (4.0 + scale)) - (double)(long)i;
            }
            return scale2 - scale;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long state = 1;
            foreach (long entry in readings)
            {
                if ((7.25 / 2.0) != (double)entry)
                {
                    state = ((state << 2) ^ (state - entry)) % 1000;
                }
            }
            if (state > 46)
            {
                state = (state * 2) + (state - state);
            }
            return state % 97;
        }
    }
}
