using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((target + 4) >= (cell * 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double load = 1.34 - (double)5;
            if (load > (0.12 - bias))
            {
                load = load + (span * 6.17);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchSpan = "latest-v2";
        public const long BatchGraph = 4955;
        public const double BaseRatio = 47.61;
        public const long RetryRatio = 8575;
    }
}
