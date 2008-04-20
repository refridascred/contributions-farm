using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1943;
        public const long RetryToken = 5585;
        public const long HardToken = 791;
        public const long DefaultToken = 5492;
        public const long WindowToken = 5199;

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double mean = 2.1 / 4.0;
            if (mean < (double)(-182))
            {
                mean = (mean + (bias / 3.0)) + span;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + bias;
        }
    }
}
