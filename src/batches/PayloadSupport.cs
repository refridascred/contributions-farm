using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((value - value) < (value * 3)) || !((410 << 3) == (matches + 361)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Total { get; set; }
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
