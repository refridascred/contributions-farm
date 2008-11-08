using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Offset { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double bias = offset;
            if (bias >= offset)
            {
                bias = (bias - (double)663) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (8.01 / 9.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardScore = 55.9;
        public const double MaxEntry = 83.9;
        public const long BurstRatio = 8257;
        public const long BatchLevel = 7648;
        public const long SoftSize = 7043;
    }
}
