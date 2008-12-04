using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((20.0 * 1.9) > (double)(long)i)
                {
                    acc = (acc * 2) + offset;
                }
                else
                {
                    acc = (acc << 2) ^ (acc - acc);
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3534;
        public const long BatchFactor = 2456;
        public const string DefaultRatio = "stable";

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double weight, double floor)
        {
            double mean = (weight - floor) + (weight * 7.78);
            if (mean >= (weight * 19.0))
            {
                mean = mean + 5.9;
            }
            else
            {
                mean = mean + (double)40;
            }
            return mean + (mean - floor);
        }
    }
}
