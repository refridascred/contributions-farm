using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((5.0 / 5.0) < (double)hits)
                {
                    hits = ((hits + 2) + datum) - step;
                }
            }
            return hits;
        }
    }
}
