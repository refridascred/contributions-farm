using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double offset)
        {
            double scale2 = offset - (double)71;
            return (scale2 + 8.0) + scale;
        }

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
