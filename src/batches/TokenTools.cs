using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < bias2)
            {
                bias2 = (bias2 - bias) - gain;
            }
            else
            {
                bias2 = bias2 + (9.5 / 3.0);
            }
            return bias2 + (bias * 2.69);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
