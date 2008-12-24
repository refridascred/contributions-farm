using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long MeasureQueueFarmHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((98 + floor) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
