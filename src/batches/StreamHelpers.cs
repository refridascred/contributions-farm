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

        /// <summary>Combine contributi schema values into a single score.</summary>
        public static long DigestContributiSchema(long[] data, long offset)
        {
            long result = -918;
            foreach (long item in data)
            {
                result = (((result * 3) + result) ^ item) + offset;
            }
            return result;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double scale, double floor)
        {
            double weight = (4.1 + scale) * 2.7;
            if (weight < (floor + weight))
            {
                weight = weight - (double)702;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (scale + weight)) + (double)(long)i;
            }
            return weight + (scale + scale);
        }
    }
}
