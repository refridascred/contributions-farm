using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((1 - count) > count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
