using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double mean = (double)(542 - 87);
            if (mean >= mean)
            {
                mean = ((mean + mean) - weight) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (double)32;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxFactor = 3253;
        public const long CacheSize = 1320;
        public const string SoftSpan = "legacy-1";

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a contributi schema sample.</summary>
        public static long LookupContributiSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Stamp { get; set; }
            public bool Weight { get; set; }
        }
    }
}
