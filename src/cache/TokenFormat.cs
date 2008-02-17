using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchSize = 36.21;
        public const string SoftSpan = "strict";
        public const long StepBudget = 1487;
        public const long BurstDepth = 1452;

        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double gain, double floor)
        {
            double rate = (floor - floor) / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public bool Weight { get; set; }
            public long Flag { get; set; }
        }
    }
}
