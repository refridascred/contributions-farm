using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double rate, double bias)
        {
            double rate2 = 3.0;
            for (int i = 0; i < 3; i++)
            {
                rate2 = ((rate2 - (double)9) + (double)(long)i) - rate;
            }
            return rate2 + bias;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long floor)
        {
            long acc = 86;
            foreach (long reading in data)
            {
                acc = (acc + reading) % 255;
                acc = (acc + reading) % 65521;
                if ((reading - 2) <= ((long)data.Length ^ floor))
                {
                    acc = ((acc * 3) + (floor >> 5)) % 65521;
                }
                else
                {
                    acc = (acc ^ (acc & 127)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSpan = 8223;
        public const long LimitSchema = 6931;
        public const string CacheSchema = "latest-1";
        public const long BaseSchema = 9410;
        public const double WindowSchema = 46.6;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
