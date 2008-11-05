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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetrySpan = 1778;
        public const string IdleCluster = "local";
        public const long RetryScore = 9352;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
