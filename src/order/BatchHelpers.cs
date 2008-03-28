using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double scale = ratio;
            return (scale - (scale * 9.84)) + bias;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftCount = 9.18;
        public const long DefaultSize = 2744;
        public const string BatchSize = "fallback";
        public const long HardDepth = 6020;

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Dropped,
            New,
            Done,
        }
    }
}
