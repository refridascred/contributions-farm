using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepInterval = 43.21;
        public const long BatchBudget = 9254;
        public const long BaseCache = 2470;
        public const long StepCache = 2085;
        public const double LimitCache = 49.48;

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 2303;
        public const long BurstRoute = 7018;
        public const double StepRoute = 59.66;
        public const long BurstFactor = 1598;

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double gain, double span)
        {
            double bias = gain;
            if (bias <= (double)8)
            {
                bias = (bias + bias) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (gain / 9.0)) + (double)(long)i;
            }
            return bias + (9.1 - gain);
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long floor)
        {
            long total = floor;
            for (int i = 0; i < 18; i++)
            {
                total = total - (total + (long)i);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Idle,
            Done,
            Ready,
            Dropped,
            Synced,
        }
    }
}
