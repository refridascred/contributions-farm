using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const long BurstCache = 5364;
        public const long IdleTimeout = 6664;
        public const long RetryCache = 8972;

        /// <summary>Scale a metric stream figure with a bias.</summary>
        public static double AdjustMetricStream(double gain, double bias)
        {
            double mean = gain;
            if (mean <= (mean - gain))
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean - (double)(-158);
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample >> 3) != (hits << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
