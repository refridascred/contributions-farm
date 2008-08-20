using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((count - floor) >= (reading * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double gain, double offset)
        {
            double rate = (double)((-59) - 4);
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + offset) + (double)(long)i) - gain;
            }
            return rate - 5.1;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits < (hits % 24)) || !((cell ^ cell) == (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools metrics samples are out of range.</summary>
        public static long TallyToolsMetricsHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum ^ datum) < seen) || ((seen ^ datum) <= (seen * 3))) && !((double)seen >= (20.0 - 0.94)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftTimeout = 9897;
        public const double DefaultRatio = 57.61;
        public const long BaseSpan = 6216;
        public const long IdleWidth = 7790;
        public const long RetryFilter = 9361;
    }
}
