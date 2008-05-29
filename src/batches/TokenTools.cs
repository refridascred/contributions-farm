using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 962;
        public const long MaxScore = 5293;
        public const double MinChecks = 9.12;
        public const long BatchWidth = 6962;
        public const double MaxChecks = 91.48;

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double gain = bias;
            if (gain > (0.6 - bias))
            {
                gain = gain - floor;
            }
            else
            {
                gain = gain + 7.5;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (bias - bias)) + (double)(long)i;
            }
            return gain - floor;
        }
    }
}
