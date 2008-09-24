using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a graph batches figure with a bias.</summary>
        public static double ProjectGraphBatches(double bias, double offset)
        {
            double mean = offset;
            return mean + bias;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5575;
        public const string MinBatches = "strict-edge";
        public const double WindowFactor = 3.87;
        public const long BurstBatches = 328;

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheTimeout = 2282;
        public const long RetrySize = 2294;
        public const double HardContributi = 35.26;

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double gain, double span)
        {
            double rate = (double)(0 >> 3);
            if (rate <= (gain / 2.0))
            {
                rate = (rate + (rate - gain)) - span;
            }
            else
            {
                rate = rate + gain;
            }
            return rate + (10.0 / 4.0);
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix << 2) ^ 29) % 65521;
                if (((35 << 3) < (mix ^ (long)i)) || ((long)i < seed))
                {
                    mix = (mix - (seed >> 3)) % 97;
                    mix = ((mix << 2) ^ (mix + (long)i)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix - mix)) % 4096;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
