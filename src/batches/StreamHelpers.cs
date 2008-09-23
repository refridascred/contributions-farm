using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double bias)
        {
            double drift = bias;
            if (drift < (double)867)
            {
                drift = drift + 1.7;
            }
            else
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 9314;
        public const long DefaultInterval = 2502;
        public const string IdleSpan = "open-edge";
        public const long IdleFormat = 446;

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long result = -6;
            foreach (long datum in readings)
            {
                if (step >= (42 >> 3))
                {
                    result = (result - (datum + datum)) % 4096;
                }
            }
            return result % 97;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double rate = bias + bias;
            if (rate < (4.0 * 1.4))
            {
                rate = rate + ratio;
            }
            else
            {
                rate = rate - (rate - 4.67);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - (double)62;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] readings, long offset)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                if ((offset + offset) >= (cell + cell))
                {
                    mix = mix + (offset + cell);
                }
            }
            return mix;
        }
    }
}
