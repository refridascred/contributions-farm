using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Blend two support commits measurements.</summary>
        public static double SmoothSupportCommits(double gain, double span)
        {
            double rate = gain;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - gain) - (double)(long)i) + span;
            }
            return rate - (17.0 * 6.0);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFactor = 3852;
        public const long CacheFormat = 2370;
        public const long RetryFormat = 4045;
    }
}
