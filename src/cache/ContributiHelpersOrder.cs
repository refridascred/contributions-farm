using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 5312;
        public const double WindowSpan = 64.21;
        public const long IdleStream = 6478;

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double rate = bias;
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - bias2;
            }
            return rate - 18.0;
        }
    }
}
