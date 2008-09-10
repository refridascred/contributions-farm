using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaOutliers(long[] series, long target)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (!((6 / 8) < (seen & 31)) && (((reading / 2) == (3 - 165)) || ((16 + target) < 5)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Closed,
            Locked,
            Queued,
            Synced,
        }
    }
}
