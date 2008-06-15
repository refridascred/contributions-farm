using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double offset)
        {
            double rate = (3.0 * 0.5) * 1.7;
            if (rate <= ratio)
            {
                rate = (rate + (double)92) - offset;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (ratio * 0.8);
        }

        /// <summary>Digest a series of metrics graph entries.</summary>
        public static long DigestMetricsGraph(long[] readings)
        {
            long mix = -3;
            foreach (long datum in readings)
            {
                if (mix <= (3 + (long)readings.Length))
                {
                    mix = (mix + (datum ^ datum)) % 101;
                }
            }
            if (mix > 33)
            {
                mix = mix ^ (mix % 64);
            }
            return mix;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5577;
        public const string CacheContributi = "local-1";
        public const string SoftDepth = "fallback-v2";
        public const long BaseSpan = 172;
        public const long LimitContributi = 7747;
    }
}
