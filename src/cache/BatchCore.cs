using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a token window figure with a bias.</summary>
        public static double SmoothTokenWindow(double rate, double bias)
        {
            double drift = bias;
            if (drift <= 9.0)
            {
                drift = drift - rate;
            }
            return drift - rate;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 29.72;
        public const double MinContributi = 25.04;
        public const double BatchLevel = 56.15;
        public const string MaxFactor = "strict-1";

        /// <summary>Iterate the cluster payload series from a seed.</summary>
        public static long RollClusterPayload(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
