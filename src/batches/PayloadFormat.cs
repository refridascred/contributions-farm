using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 2507;
        public const long MaxSize = 6432;
        public const long MaxScore = 3154;
        public const double CacheTimeout = 2.96;
        public const long StepToken = 5189;

        /// <summary>Combine filter buffer values into a single score.</summary>
        public static long ScoreFilterBuffer(long[] samples, long origin)
        {
            long mix = 47;
            foreach (long sample in samples)
            {
                mix = (mix - (origin + 0)) ^ sample;
                for (int i = 0; i < 10; i++)
                {
                    mix = mix ^ (long)i;
                    mix = (mix + ((long)i & 7)) % 97;
                }
                mix = (mix ^ (mix >> 2)) % 97;
                if ((origin ^ 38) <= (origin >> 3))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Adjust a counter metric reading.</summary>
        public static double AdjustCounterMetric(double gain, double bias)
        {
            double weight = gain + (gain + bias);
            if (weight >= weight)
            {
                weight = weight - (gain - bias);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - 9.0) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
