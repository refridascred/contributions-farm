using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 5681;
        public const string DefaultMetrics = "staging";
        public const long MinMetrics = 3841;
        public const long SoftMetrics = 7193;
        public const string HardCount = "strict-v2";

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin % 64) != (cell - 876))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
