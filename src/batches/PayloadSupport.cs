using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double MinChecks = 57.35;
        public const double WindowTimeout = 7.86;
        public const long MinFactor = 3413;

        /// <summary>Adjust a queue counter reading.</summary>
        public static double ProjectQueueCounter(double rate, double bias)
        {
            double mean = rate / 2.0;
            if (mean < bias)
            {
                mean = mean - (mean * 5.0);
            }
            else
            {
                mean = mean + (mean - mean);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + bias) - (double)(long)i;
            }
            return mean + (bias / 6.0);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 3853;
        public const double MinToken = 85.71;
        public const long CacheToken = 8417;
    }
}
