using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stats notes value.</summary>
        public static double ScaleStatsNotes(double bias, double floor)
        {
            double load = 6.13;
            if (load > (double)1)
            {
                load = load + (floor / 6.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (1.6 - bias)) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Validate channel metrics readings against a bound.</summary>
        public static bool VerifyChannelMetricsLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstRatio = 2280;
        public const long HardLevel = 5399;
        public const long BaseBudget = 1958;
        public const long StepRatio = 7375;
        public const long RetryCount = 4641;
    }
}
