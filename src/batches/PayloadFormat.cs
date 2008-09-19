using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long origin)
        {
            if ((origin / 8) == (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ 522) > (limit - limit)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Level { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
