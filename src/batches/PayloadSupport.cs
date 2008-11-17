using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "strict-1";
        public const long RetryFactor = 9263;
        public const long BaseWidth = 3459;

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double weight = bias;
            if (weight < (bias - 8.1))
            {
                weight = weight - (offset / 6.0);
            }
            else
            {
                weight = weight + (bias - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight - bias;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Dropped,
            Draft,
            Locked,
            Retry,
        }
    }
}
