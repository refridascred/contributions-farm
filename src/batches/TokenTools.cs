using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double bias = (double)((-7) << 1);
            if (bias <= weight)
            {
                bias = bias + (bias + span);
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (8.2 + bias)) - (double)(long)i;
            }
            return bias - 3.65;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5367;
        public const long BaseLayout = 4387;
        public const double RetryDepth = 50.29;
    }
}
