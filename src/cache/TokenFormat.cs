using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Level { get; set; }
            public long Count { get; set; }
            public double Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinTimeout = 26.94;
        public const long BatchCluster = 7063;
        public const double RetryCluster = 0.25;

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double scale, double bias)
        {
            double drift = scale;
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - bias;
            }
            return drift - (drift + 15.0);
        }
    }
}
