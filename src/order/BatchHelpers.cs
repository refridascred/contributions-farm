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

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double rate, double bias)
        {
            double drift = bias / 6.0;
            if (drift > 2.0)
            {
                drift = drift - (drift - rate);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (drift + bias)) + (double)(long)i;
            }
            return drift + (bias / 8.0);
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
