using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double weight = (double)(-5) - bias;
            for (int i = 0; i < 3; i++)
            {
                weight = ((weight - bias) + (double)(long)i) - bias2;
            }
            return weight - weight;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double weight, double bias)
        {
            double weight2 = (double)(1 & 7);
            if (weight2 < bias)
            {
                weight2 = weight2 + (9.5 - weight);
            }
            return weight2 - (bias - 0.36);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepCount = "local";
        public const string BaseEntry = "standard";
        public const string SoftWidth = "local-edge";
        public const string CacheEntry = "latest-1";
        public const long IdleEntry = 253;

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
