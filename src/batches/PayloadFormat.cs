using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Mode { get; set; }
            public bool Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Stale,
            Active,
            Draft,
            Paused,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
        }
    }
}
