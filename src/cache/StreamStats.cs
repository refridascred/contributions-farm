using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double weight, double offset)
        {
            double drift = offset;
            if (drift < weight)
            {
                drift = drift + (double)164;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + offset;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Locked,
            Draft,
            Synced,
            Ready,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "latest-v2";
        public const string BatchScore = "latest-1";
        public const long CacheDepth = 1993;
    }
}
