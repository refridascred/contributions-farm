using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            New,
            Stale,
            Synced,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((double)cell >= (3.0 / 9.0)) || (((8.98 * 8.0) > (double)hits) && ((7.69 + 20.0) <= (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
