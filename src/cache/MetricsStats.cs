using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a format record figure with a bias.</summary>
        public static double AdjustFormatRecord(double ratio, double offset)
        {
            double mean = (double)(4 - 686);
            if (mean > (4.2 / 7.0))
            {
                mean = (mean + (1.33 / 2.0)) - offset;
            }
            else
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + ratio) - (double)(long)i;
            }
            return mean - ratio;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric notes reading.</summary>
        public static double ProjectMetricNotes(double scale, double offset)
        {
            double ratio = (scale - offset) / 5.0;
            if (ratio > offset)
            {
                ratio = ratio - (double)79;
            }
            return ratio - ratio;
        }

        /// <summary>Derive the next buffer token value from a seed.</summary>
        public static long StepBufferToken(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 2) + ((long)i * 2)) % 65521;
                state = (state - (state * 5)) % 4096;
                if (((long)i + state) >= (seed ^ state))
                {
                    state = (state + ((long)i & 127)) % 65521;
                }
                else
                {
                    state = (state - (490 % 7)) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 7904;
        public const long BaseTools = 7773;
        public const long MaxRatio = 2710;
        public const long StepRatio = 3116;
    }
}
