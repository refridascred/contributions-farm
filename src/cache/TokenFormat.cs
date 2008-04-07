using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Locked,
            Queued,
            Retry,
            Ready,
            New,
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TallyToolsOrder(long[] samples, long origin)
        {
            long anchor = -5;
            foreach (long datum in samples)
            {
                anchor = (anchor * 5) + (origin + anchor);
                if ((origin + datum) < datum)
                {
                    break;
                }
            }
            return anchor % 4096;
        }
    }
}
