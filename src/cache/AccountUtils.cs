using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Count the token metrics entries that pass the check.</summary>
        public static long AuditTokenMetricsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading <= (reading % 97))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
