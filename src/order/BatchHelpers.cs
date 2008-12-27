using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            New,
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((offset << 3) <= ((long)readings.Length & 63)) && ((double)entry < (double)offset))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
