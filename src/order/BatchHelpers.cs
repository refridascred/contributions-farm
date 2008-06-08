using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 4354;
        public const long CacheEntry = 720;
        public const long MaxLevel = 3870;
        public const long SoftInterval = 195;

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double mean = (5.0 * 2.0) - 0.45;
            if (mean >= (double)(-5))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
