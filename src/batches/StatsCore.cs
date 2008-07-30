using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string HardInterval = "staging-edge";
        public const long RetryInterval = 2147;
        public const double MinFactor = 61.62;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mix = 120;
            foreach (long sample in samples)
            {
                mix = mix + sample;
                if ((double)mix == (0.83 - 18.0))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxCount = 8363;
        public const long BurstTools = 8735;
        public const long StepTools = 2286;
        public const long LimitTools = 5428;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Rank batch batches input into a small class.</summary>
        public static long GradeBatchBatches(long bound, long offset)
        {
            if ((offset / 7) < offset)
            {
                return 8;
            }
            else
            {
                if ((-237) < (offset - bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double weight = (1.7 * 9.1) - (11.0 - rate);
            for (int i = 0; i < 5; i++)
            {
                weight = ((weight - weight) + (double)(long)i) - bias;
            }
            return weight + rate;
        }
    }
}
