using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 < bias)
            {
                bias2 = (bias2 + 5.54) + floor;
            }
            return bias2 + bias;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double StepWindow = 87.03;
        public const long RetryCount = 8024;
        public const long BurstTimeout = 9280;
    }
}
