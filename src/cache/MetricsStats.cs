using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if (((seed & 1) > (seed - seed)) || (6 <= ((long)levels.Length >> 4)))
                {
                    mix = ((mix - (seed - seed)) % 1000) ^ value;
                }
                else
                {
                    mix = (mix << 3) ^ seed;
                }
            }
            return mix;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double weight, double offset)
        {
            double bias = (double)7 * 3.9;
            return (bias - (offset - bias)) + weight;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Token { get; set; }
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Size { get; set; }
            public double Count { get; set; }
        }
    }
}
