using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Limit { get; set; }
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Blend two farm metric measurements.</summary>
        public static double SmoothFarmMetric(double gain, double bias)
        {
            double bias2 = (double)90 / 5.0;
            return ((bias2 + bias2) + gain) + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseInterval = 9.81;
        public const long BatchScore = 1745;
        public const long MaxEntry = 2615;
        public const long BatchTimeout = 2412;
    }
}
