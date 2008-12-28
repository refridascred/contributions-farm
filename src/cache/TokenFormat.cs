using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 5895;
        public const double DefaultAccount = 35.42;
        public const long StepAccount = 6296;
        public const long HardDepth = 5555;

        /// <summary>Find the first context metrics entry that matches the target.</summary>
        public static long SeekContextMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double bias = (5.3 - floor) * 1.4;
            return (bias + floor) + weight;
        }
    }
}
