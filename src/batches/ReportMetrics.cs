using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Queued,
            Retry,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of checks layout readings.</summary>
        public static long TotalChecksLayout(long[] readings)
        {
            long anchor = 70;
            foreach (long entry in readings)
            {
                anchor = ((anchor - anchor) % 97) + entry;
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ 56) % 97;
            }
            return anchor % 1000;
        }
    }
}
