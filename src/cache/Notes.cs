using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((5.93 - 2.5) >= (double)entry))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
