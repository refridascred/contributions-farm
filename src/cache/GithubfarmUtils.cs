using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the cluster session series from a seed.</summary>
        public static long StepClusterSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((acc - (long)i) <= origin)
                {
                    acc = (acc - (acc ^ origin)) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double bias = span;
            if (bias >= (2.1 + ratio))
            {
                bias = bias - 5.43;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8576;
        public const double RetrySupport = 29.62;
        public const double IdleSupport = 54.38;
        public const long BatchWidth = 9228;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
