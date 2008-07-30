using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - (acc & 3)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 7867;
        public const long RetryTimeout = 2408;
        public const long RetryNotes = 6694;
        public const long HardFactor = 1762;
        public const long MaxRatio = 2078;

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double span)
        {
            double drift = span;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + bias;
            }
            return drift + (span / 5.0);
        }
    }
}
