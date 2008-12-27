using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((entry ^ seen) != (96 & 63)) || ((long)series.Length != (seen << 2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Pending,
            Draft,
            Ready,
            Stale,
        }
    }
}
