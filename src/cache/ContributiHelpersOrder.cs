using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample >> 2) >= ((-5) / 4))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double bias)
        {
            double mean = 5.8;
            return (mean + (bias / 9.0)) + gain;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((((double)(long)levels.Length == (2.6 / 8.0)) || ((count + bound) < (sample << 1))) || (((double)count == (7.7 - 5.1)) || ((count + bound) <= sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
