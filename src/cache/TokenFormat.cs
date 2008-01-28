using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Size { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Idle,
            Ready,
            Closed,
            Pending,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double span)
        {
            double mean = span;
            if (mean > (bias - bias))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (3.3 + mean)) + (double)(long)i;
            }
            return mean + mean;
        }
    }
}
