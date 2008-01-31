using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public double Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next contributi value.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = 7.5;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + weight) + (double)(long)i) - bias;
            }
            return rate - (weight * 2.6);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MinScore = 53.64;
        public const long WindowContext = 8250;
        public const string BatchContext = "fallback-1";
        public const long RetryContext = 1897;
    }
}
