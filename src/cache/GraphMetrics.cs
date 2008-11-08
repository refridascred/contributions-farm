using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Queued,
            Stale,
            Active,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 4446;
        public const long BaseSpan = 3997;
        public const double StepBuffer = 53.59;
        public const long BurstBuffer = 3031;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Locked,
            Draft,
            New,
        }
    }
}
