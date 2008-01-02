using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double SoftScore = 32.14;
        public const string DefaultTimeout = "cached-edge";
        public const long BatchAlready = 6691;

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Stamp { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double bias2)
        {
            double bias3 = 4.4;
            if (bias3 < bias3)
            {
                bias3 = (bias3 + (double)4) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                bias3 = (bias3 + (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 - (bias2 + 7.1);
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long mark = -5;
            foreach (long sample in items)
            {
                mark = ((mark * 5) + (mark % 64)) - sample;
            }
            if (mark < 348)
            {
                mark = (mark ^ (65 << 1)) % 97;
            }
            return mark;
        }
    }
}
