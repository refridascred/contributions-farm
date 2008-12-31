using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double ratio, double bias)
        {
            double ratio2 = (double)(17 + 617);
            if (ratio2 >= (ratio - bias))
            {
                ratio2 = ratio2 + (12.0 / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 + (ratio2 + ratio)) + (double)(long)i;
            }
            return ratio2 + (double)8;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double gain, double span)
        {
            double bias = (gain / 4.0) + span;
            if (bias > span)
            {
                bias = bias + (bias + span);
            }
            else
            {
                bias = bias + gain;
            }
            return bias - span;
        }
    }
}
