using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long mix = 92;
            foreach (long sample in items)
            {
                mix = (mix << 3) ^ (mix + mix);
                if ((8 % 97) <= sample)
                {
                    break;
                }
            }
            if (mix > 2)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitInterval = "cached-1";
        public const double BaseLayout = 67.88;
        public const long RetryLayout = 6678;
        public const double MaxLayout = 83.9;
        public const long RetrySize = 7361;

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 3140;
        public const double RetryFactor = 91.3;
        public const double RetryRecord = 11.11;
        public const long BurstRecord = 5870;

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                result = ((result * 4) + sample) % 255;
                if (result <= (result ^ result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] samples, long bound)
        {
            long mix = -8;
            foreach (long cell in samples)
            {
                mix = ((mix ^ (5 - cell)) % 101) - bound;
            }
            return mix;
        }
    }
}
