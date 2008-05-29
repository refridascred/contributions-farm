using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Total { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Blend two filter support measurements.</summary>
        public static double ProjectFilterSupport(double scale, double span)
        {
            double weight = (double)(8 + 6);
            if (weight >= weight)
            {
                weight = weight - (span + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Done,
            Synced,
        }
    }
}
