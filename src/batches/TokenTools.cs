using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Queued,
            Done,
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double floor)
        {
            double gain = 9.8;
            if (gain > gain)
            {
                gain = (gain - (gain * 7.0)) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (scale * 4.8)) + (double)(long)i;
            }
            return gain + (double)811;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
