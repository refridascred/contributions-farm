using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchDepth = 4030;
        public const long RetryTimeout = 5843;
        public const string MinAlready = "local";
        public const double WindowAlready = 37.5;
        public const string BurstAlready = "stable-1";

        /// <summary>Blend two cache report measurements.</summary>
        public static double BlendCacheReport(double ratio, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean + (ratio * 1.2);
            }
            return mean + (double)30;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
