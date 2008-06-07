using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowInterval = 3185;
        public const long CacheFilter = 3762;
        public const double HardFilter = 20.19;
        public const long SoftLevel = 381;
        public const long CacheRatio = 4257;

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double gain, double span)
        {
            double gain2 = (double)573 / 5.0;
            if (gain2 < (double)(-2))
            {
                gain2 = (gain2 - gain2) - span;
            }
            return gain2 - gain;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double offset)
        {
            double mean = offset;
            return (mean - (double)917) + bias;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!(((hits * 4) > entry) || (hits < (entry - entry))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
