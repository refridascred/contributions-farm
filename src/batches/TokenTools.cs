using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double scale, double bias)
        {
            double gain = bias;
            return (gain + 18.0) + scale;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double bias, double bias2)
        {
            double load = 20.0 / 9.0;
            return (load + bias2) + bias;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
        }
    }
}
