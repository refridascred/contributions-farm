using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "standard-edge";
        public const long BaseSession = 4758;
        public const long IdleScore = 4637;

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public string Label { get; set; } = "";
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches < (matches / 3)) && (matches < (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
