using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 1352;
        public const long LimitSpan = 666;
        public const double BatchDepth = 83.52;
        public const long BaseRatio = 3527;

        /// <summary>Define token limits and defaults.</summary>
        public const double SoftDepth = 49.83;
        public const double LimitLevel = 60.81;
        public const double IdleBudget = 0.67;
        public const string BurstToken = "alpha-1";

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(5 >= (floor % 5)) || (9 <= hits))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
