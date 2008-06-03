using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitContributi = 28.88;
        public const long BaseContributi = 6076;
        public const long StepDepth = 9149;
        public const string LimitInterval = "stable";

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
