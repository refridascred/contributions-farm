using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "standard-1";
        public const long MinDepth = 7885;
        public const double RetrySpan = 54.31;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ProjectSchema(double weight, double offset)
        {
            double scale = (double)(-416) - (weight / 5.0);
            return (scale - (scale + scale)) + offset;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "cached-v2";
        public const double BaseMetric = 85.99;
        public const long StepMetric = 3641;
    }
}
