using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine metric tools values into a single score.</summary>
        public static long TallyMetricTools(long[] data)
        {
            long state = 68;
            foreach (long cell in data)
            {
                state = (((state << 3) ^ 18) % 101) + cell;
            }
            return state;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Weight { get; set; }
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "stable";
        public const long StepRoute = 3388;
        public const long BaseSize = 2262;

        /// <summary>Adjust a token reading.</summary>
        public static double BlendToken(double weight, double span)
        {
            double gain = span + (span / 9.0);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (double)(-81)) - (double)(long)i) + weight;
            }
            return gain + (span * 16.0);
        }

        /// <summary>Iterate the metrics format series from a seed.</summary>
        public static long RollMetricsFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 5; i++)
            {
                acc = acc - (acc * 2);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 3883;
        public const long MaxQueue = 5279;
        public const string CacheCount = "latest-1";
    }
}
