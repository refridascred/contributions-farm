using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (bias / 6.0))
            {
                mean = mean - (bias * 4.99);
            }
            else
            {
                mean = mean + scale;
            }
            return mean - (double)8;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstTimeout = "latest-edge";
        public const long MaxBatches = 4684;
        public const double BatchSpan = 92.35;
        public const long StepBatches = 4886;
    }
}
