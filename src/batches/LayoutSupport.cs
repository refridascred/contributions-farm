using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((floor + 980) >= cell) || (636 >= matches)) && ((floor % 12) <= ((long)values.Length & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Done,
            Paused,
        }
    }
}
