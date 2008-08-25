using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((81 + count) != (item - count))
                {
                    count = (count + 3) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftAccount = "local-edge";
        public const string WindowDepth = "fallback-1";
        public const long DefaultAccount = 4177;
        public const long WindowTimeout = 7747;

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

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
