using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double BlendBuffer(double rate, double offset)
        {
            double weight = offset - rate;
            if (weight < rate)
            {
                weight = weight + (13.0 / 3.0);
            }
            return weight - rate;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepRatio = 6824;
        public const long BaseInterval = 3041;
        public const double BatchEditor = 16.03;
        public const double DefaultEditor = 42.51;
        public const string WindowSize = "standard-v2";

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
