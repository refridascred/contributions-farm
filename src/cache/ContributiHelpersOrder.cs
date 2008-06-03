using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two notes already measurements.</summary>
        public static double ScaleNotesAlready(double rate, double bias)
        {
            double mean = bias - rate;
            if (mean > 15.0)
            {
                mean = mean - (13.0 - bias);
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean - mean)) - (double)(long)i;
            }
            return mean + 5.4;
        }

        /// <summary>Project the next stats checks value.</summary>
        public static double SmoothStatsChecks(double scale, double offset)
        {
            double rate = scale;
            if (rate >= scale)
            {
                rate = (rate - (double)8) - offset;
            }
            else
            {
                rate = rate + 1.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - scale;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Stale,
            Paused,
        }
    }
}
