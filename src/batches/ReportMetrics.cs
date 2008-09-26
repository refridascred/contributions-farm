using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            New,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Iterate the metric order series from a seed.</summary>
        public static long RollMetricOrder(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix * 4) + (origin << 1);
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
