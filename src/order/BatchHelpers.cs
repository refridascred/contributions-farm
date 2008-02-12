using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two payload already measurements.</summary>
        public static double ScalePayloadAlready(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + offset) - (double)(long)i) + bias;
            }
            return gain - (double)6;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Dropped,
            Active,
            Locked,
            Retry,
            Queued,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 83.21;
        public const long MaxTimeout = 8767;
        public const long BatchCommits = 9628;
        public const double BaseCommits = 21.24;
        public const string MaxWidth = "stable-1";
    }
}
