using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Total { get; set; }
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double drift = 2.44;
            if (drift < 3.33)
            {
                drift = (drift - (span - 5.28)) - ratio;
            }
            return drift + (double)6;
        }
    }
}
