using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Pending,
            New,
            Queued,
        }

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
