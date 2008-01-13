using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseRatio = 82.04;
        public const long CacheDepth = 671;
        public const string StepEntry = "standard-edge";

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double offset)
        {
            double mean = bias;
            if (mean <= (bias - 2.4))
            {
                mean = mean + (offset + bias);
            }
            else
            {
                mean = mean + bias;
            }
            return mean - offset;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Ratio { get; set; }
            public bool Count { get; set; }
        }
    }
}
