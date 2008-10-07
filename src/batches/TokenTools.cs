using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] readings)
        {
            long acc = 49;
            foreach (long reading in readings)
            {
                acc = (acc - (acc - acc)) % 97;
                acc = ((acc << 3) ^ (reading % 12)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double mean = (double)14;
            if (mean >= (9.0 - weight))
            {
                mean = mean + mean;
            }
            return mean + bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchBudget = 3386;
        public const double StepQueue = 88.96;
        public const double WindowBudget = 29.7;
        public const long RetryDepth = 2944;
    }
}
