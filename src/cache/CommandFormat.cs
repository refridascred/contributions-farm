using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4384;
        public const long BatchWindow = 3222;
        public const long MinWindow = 2126;

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double load = (double)877 + (offset / 8.0);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) + (double)(long)i) - weight;
            }
            return load + (6.6 + 3.72);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen >= (sample ^ seen))
                {
                    seen = (seen + 3) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
