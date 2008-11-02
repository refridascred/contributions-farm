using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value / 5) < target)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Done,
            Failed,
        }
    }
}
