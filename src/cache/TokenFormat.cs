using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public bool Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (count ^ origin))
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Stale,
            Locked,
            Failed,
            Paused,
        }
    }
}
