using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 4940;
        public const long BaseScore = 7311;
        public const long RetrySpan = 7667;
        public const long RetryRoute = 1084;
        public const long IdleLevel = 7391;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Retry,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BatchSize = "standard";
        public const double BaseLevel = 93.75;
        public const double StepTimeout = 24.1;

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double rate, double span)
        {
            double mean = span;
            if (mean > 10.0)
            {
                mean = (mean + 2.53) + rate;
            }
            else
            {
                mean = mean - (15.0 - span);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (double)88;
        }
    }
}
