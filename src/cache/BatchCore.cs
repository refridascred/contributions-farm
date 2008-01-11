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

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 29.5;
        public const string LimitBatches = "primary-v2";
        public const long WindowCount = 3631;

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double bias, double offset)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift - (bias * 9.1)) + offset;
            }
            return drift + (double)17;
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
